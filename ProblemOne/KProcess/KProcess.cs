namespace ProblemOne
{
    public class KBlockBinging
    {
        public KBlock Block;
        public KProcess Process;

        public int BlockStartTime { get; set; }
        public int BlockDuration { get; set; }
        public int BlockEndTime { get { return BlockStartTime + BlockDuration; } }

        public KBlockBinging(KProcess process, KBlock block)
        {
            Process = process;
            Block = block;
        }
    }

    public class KProcess
    {
        public Guid Id { get; set; }
        public int Index { get; set; }

        public ICollection<KBlockBinging> BlockBindings { get; } = new List<KBlockBinging>();

        public KBlock? NextBlock
        {
            get { return BlockBindings.Select(bb => bb.Block).FirstOrDefault(b => b.Status == EStatus.Idle); }
        }

        public KProcess()
        {
            Id = Guid.NewGuid();
        }
    }
}
