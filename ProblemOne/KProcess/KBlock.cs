namespace ProblemOne
{
    public class KBlock
    {
        public Guid Id { get; set; }

        public int PipelineIndex { get; set; }

        public ICollection<KBlockBinging> Bindings { get; } = new HashSet<KBlockBinging>();

        public KProcess? CurrentExecutor { get; set; } = null;
            
        public EStatus Status 
        { 
            get
            {
                if (Bindings.All(b => b.Status == EStatus.Done)) return EStatus.Done;
                if (Bindings.Any(b => b.Status == EStatus.Busy)) return EStatus.Busy;
                return EStatus.Idle;
            }
        }

        public KBlock()
        {
            Id = Guid.NewGuid();
            PipelineIndex = 0;
        }
        public KBlock(int index)
        {
            Id = Guid.NewGuid();
            PipelineIndex = index;
        }
    }
}