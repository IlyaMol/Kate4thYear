namespace ProblemOne
{
    public class KProcess
    {
        public Guid Id { get; set; }
        public int Index { get; set; }
        public int ThreadIndex { get; set; }
        public KStatus Status 
        { 
            get
            {
                if (NextBlock == null) return KStatus.Done;

                if (CurrentBlock == null || CurrentBlock.Status == KStatus.Idle || CurrentBlock.Status == KStatus.Done)
                    return KStatus.Idle;
                
                return KStatus.Busy;
            } 
        }

        public KBlock? CurrentBlock
        {
            get { return Blocks.FirstOrDefault(b => b.Status == KStatus.Busy); }
            set
            {
                if (value == null) return;
                KBlock? block = Blocks.FirstOrDefault(b => b.Id == value.Id);
                if (block == null) return;
                block.Status = KStatus.Busy;
            }
        }
        public KBlock? NextBlock
        {
            get { return Blocks.FirstOrDefault(b => b.Status == KStatus.Idle); }
        }

        public ICollection<KBlock> Blocks { get; set; } = new List<KBlock>();

        public KProcess()
        {
            Id = Guid.NewGuid();
        }
    }
}
