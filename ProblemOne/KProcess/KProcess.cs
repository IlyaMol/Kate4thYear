namespace ProblemOne
{
    public static class KProcessExtensions
    {
        public static KProcess AddBlockBinding(this KProcess process, KBlock block, int blockDuration)
        {
            process.BlockBindings.Add(new KBlockBinging(process, block, blockDuration));
            return process;
        }
    }

    public class KBlockBinging
    {
        public KBlock Block { get; private set; }
        public KProcess Process { get; set; }

        // if it is equal to -1 - the block was not executed in any process
        public int BlockStartTime { get; set; } = -1;

        public int BlockDuration { get; set; }
        public int BlockEndTime { get { return BlockStartTime + BlockDuration; } }

        public EStatus Status { get; set; } = EStatus.Idle;

        public KBlockBinging(KProcess process, KBlock block, int blockDuration)
        {
            Process = process;
            Block = block;
            BlockDuration = blockDuration;
            Block.Bindings.Add(this);
        }
    }

    public class KProcess
    {
        public Guid Id { get; set; }
        public int Index { get; set; }

        public ICollection<KBlockBinging> BlockBindings { get; } = new List<KBlockBinging>();
        public EStatus Status
        {
            get
            {
                if(BlockBindings.Any(bb => bb.Block.Status == EStatus.Busy))
                    return EStatus.Busy;
                if(BlockBindings.All(bb => bb.Block.Status == EStatus.Done))
                    return EStatus.Done;
                return EStatus.Idle;
            }
        }

        public KBlock? NextBlock
        {
            get { return BlockBindings.Select(bb => bb.Block).FirstOrDefault(b => b.Status == EStatus.Idle); }
        }

        public KProcess(int index)
        {
            Id = Guid.NewGuid();
            Index = index;
        }
    }
}
