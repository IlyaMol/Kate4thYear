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

        public KBlockBinding? PreviousBlock 
        { 
            get
            {
                return Process.BlockBindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex - 1);
            } 
        }
        public KBlockBinding? NextBlock
        {
            get
            {
                return Process.BlockBindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex + 1);
            }
        }
        public KBlockBinding? PreviousBlockBindingForBlock
        {
            get
            {
                return Block.Bindings.Where(bb => bb.Process.IsCurrentlyBinded).FirstOrDefault(bb => bb.Process.Index == Process.Index - 1);
            }
        }

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

        public int DoTick(int currentTick, EProcType syncType)
        {
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
                            if (PreviousBlock != null && PreviousBlock.BlockEndTime != BlockStartTime)
                                PreviousBlock.BlockStartTime = BlockStartTime - PreviousBlock.BlockDuration;

                        if (syncType == EProcType.SyncSecond)
                        {
                            var blockBindings = Block.Bindings.Where(bb => bb.Process.IsCurrentlyBinded);

                            if (blockBindings.Any())
                                if (PreviousBlock != null && Block.IsCompleted())
                                {
                                    while (blockBindings.All(bb => bb.BlockStartTime > bb.PreviousBlock!.BlockEndTime))
                                        foreach (KBlockBinding bb in blockBindings)
                                            bb.BlockStartTime--;
                                    currentTick = blockBindings.Max(bb => bb.BlockEndTime);
                                }
                        }
                    }
                }
            }
            else
            {
                if(syncType == EProcType.SyncFirst)
                {
                    // откладываем выполнение, если время окончания выполнения текущего блока
                    // не совпадает со временем старта выполнения следующего
                    if (NextBlock != null && NextBlock.Block.IsBlocked)
                        if(NextBlock.Block.CalculatedCurrentEndTime > currentTick + BlockDuration)
                            return currentTick;
                }
                if (syncType == EProcType.SyncSecond)
                {
                    // откладываем назначение, если предыдущий блок не выполнен
                    // на всех процессорах
                    if (PreviousBlock != null)
                        if (!PreviousBlock.Block.IsCompleted()) return currentTick;
                }

                // обеспечивает линейный порядок
                // предоставления блоков процессорам
                if (PreviousBlockBindingForBlock != null
                    && PreviousBlockBindingForBlock.Status == BlockState.Ready) return currentTick;

                Block.IsBlocked = true;
                BlockStartTime = currentTick;
                Block.CurrentProcess = this.Process;
                Block.LastExecutorIndex = this.Process.Executor!.Index;
            }
            return currentTick;
        }

        public void Reset()
        {
            BlockStartTime = 0;
            _status = BlockState.Ready;
        }
    }
}
