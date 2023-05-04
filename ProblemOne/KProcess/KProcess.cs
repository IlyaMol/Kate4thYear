namespace ProblemOne
{
    public enum EProcessStatus
    {
        Ready,
        Binded,
        Done
    }

    public static class KProcessExtensions
    {
        public static KProcess AddBlockBinding(this KProcess process, KBlock block, int blockDuration)
        {
            process.BlockBindings.Add(new KBlockBinging(block, blockDuration));
            return process;
        }
    }

    public class KBlockBinging
    {
        public KBlock Block { get; private set; }

        public int BlockStartTime { get; set; }
        public int BlockDuration { get; set; }
        public int BlockEndTime { get { return BlockStartTime + BlockDuration; } }

        private EStatus _status = EStatus.Idle;
        public EStatus Status 
        {
            get
            {
                if (Block.IsBlocked)
                    _status = EStatus.Busy;
                else
                    _status = EStatus.Idle;
                return _status;
            }
            set
            {
                if (value == EStatus.Busy)
                {
                    _status = EStatus.Busy;
                    Block.IsBlocked = true;
                }
                else
                {
                    _status = value;
                    Block.IsBlocked = false;
                }
            }
        }

        public KBlockBinging(KBlock block, int blockDuration)
        {
            Block = block;
            BlockDuration = blockDuration;
        }

        public int ExecuteBlock(int startStamp)
        {
            Status= EStatus.Busy;
            BlockStartTime = startStamp;
            return Block.PipelineIndex;
        }
    }

    public class KProcess
    {
        public int Index { get; set; }

        public ICollection<KBlockBinging> BlockBindings { get; } = new List<KBlockBinging>();

        public KProcessor? Executor { get; set; } = null;

        public int LastExecutedBlockIndex { get; set; } = -1;

        public EProcessStatus Status
        {
            get
            {
                if (Executor != null) return EProcessStatus.Binded;
                if (BlockBindings.All(bb => bb.Status == EStatus.Done)) return EProcessStatus.Done;
                return EProcessStatus.Ready;
            }
        }

        public KBlockBinging? NextBlock
        {
            get { return BlockBindings.Where(bb => bb.Status != EStatus.Done).FirstOrDefault(b => b.Block.PipelineIndex == LastExecutedBlockIndex +1); }
        }

        public KProcess(int index)
        {
            Index = index;
        }
    }
}
