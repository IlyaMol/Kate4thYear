using ProblemOne.KStates;

namespace ProblemOne
{
    public class KBlockBinding
    {
        public KBlock Block { get; private set; }
        public KProcess Process { get; private set; }
        public int BlockStartTime { get; set; }
        public int BlockDuration { get; set; }
        public int BlockEndTime { get { return BlockStartTime + BlockDuration; } }

        private BlockState _status = BlockState.Ready;
        public BlockState Status
        {
            get
            {
                // если статус == выполнен, то иное не имеет смысла до вызова Reset()
                if(_status == BlockState.Done) return BlockState.Done;

                if (Block.IsBlocked)
                {
                    if(Block.CurrentProcess == Process)
                        return BlockState.Busy;
                    else
                        return BlockState.Waiting;
                }
                else
                    return BlockState.Ready;
            }
        }

        public KBlockBinding(KBlock block, KProcess process, int blockDuration)
        {
            Block = block;
            Process = process;
            BlockDuration = blockDuration;
        }

        public void DoTick(int currentTick, EProcType syncType)
        {
            var nextBlock = Process.BlockBindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex + 1);
            var prevBlock = Process.BlockBindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex - 1);

            if (Block.IsBlocked)
            {
                if (Block.CurrentProcess == Process)
                {
                    // выполнение блока закончилось
                    if (BlockEndTime <= currentTick)
                    {
                        Block.IsBlocked = false;
                        _status = BlockState.Done;
                        Block.CurrentProcess = null;

                        if (syncType == EProcType.SyncFirst)
                            if (prevBlock != null && prevBlock.BlockEndTime != BlockStartTime)
                                prevBlock.BlockStartTime = BlockStartTime - prevBlock.BlockDuration;
                    }
                }
            }
            else
            {
                if(syncType == EProcType.SyncFirst)
                {
                    // откладываем выполнение, если время окончания выполнения текущего блока
                    // не совпадает со временем старта выполнения следующего
                    // (относительно текущего тика машины)
                    if(nextBlock != null && nextBlock.Block.IsBlocked)
                        if(nextBlock.Block.CalculatedCurrentEndTime > currentTick + BlockDuration)
                            return;
                }
                if (syncType == EProcType.SyncSecond)
                {
                    // откладываем назначение, если текущий блок не выполнен
                    // на всех процессорах

                }

                // выполняем блок
                // обеспечивая линейный порядок
                // предоставления блоков процессорам
                if (Block.LastExecutorIndex == this.Process.Executor!.ParentMachine.Processors.Count-1)
                    Block.LastExecutorIndex = -1;

                if(Block.LastExecutorIndex == Process.Executor!.Index 
                    || Block.LastExecutorIndex == Process.Executor!.Index - 1 
                    || Block.LastExecutorIndex == -1)
                {
                    Block.IsBlocked = true;
                    BlockStartTime = currentTick;
                    Block.CurrentProcess = this.Process;
                    Block.LastExecutorIndex = this.Process.Executor!.Index;
                }
            }
            return;
        }

        public void Reset()
        {
            BlockStartTime = 0;
            _status = BlockState.Ready;
        }
    }
}
