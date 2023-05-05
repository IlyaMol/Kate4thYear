using ProblemOne.KStates;

namespace ProblemOne
{
    public class KBlockBinging
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
                if(_status == BlockState.Done) return _status;

                if (Block.IsBlocked)
                    _status = BlockState.Busy;
                else
                    _status = BlockState.Ready;
                return _status;
            }
        }

        public KBlockBinging(KBlock block, KProcess process, int blockDuration)
        {
            Block = block;
            Process = process;
            BlockDuration = blockDuration;
        }

        public int DoTick(int currentTick)
        {
            if (Block.IsBlocked && Block.CurrentProcess == Process)
            {
                // выполнение блока закончилось
                if(BlockEndTime <= currentTick)
                {
                    Block.IsBlocked = false;
                    _status = BlockState.Done;
                }
            }
            else
            {
                // выполняем блок
                Block.IsBlocked = true;
                BlockStartTime = currentTick;
                Block.CurrentProcess = this.Process;
            }
            return Block.PipelineIndex;
        }
    }
}
