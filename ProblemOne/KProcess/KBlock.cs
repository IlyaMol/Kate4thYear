namespace ProblemOne
{
    public class KBlock
    {
        public Guid Id { get; set; }
        public int PipelineIndex { get; set; }

        public bool IsBlocked { get; set; } = false;

        public KProcess? CurrentProcess { get; set; }
        public int LastExecutorIndex { get; set; } = -1;

        public ICollection<KBlockBinding> Bindings { get; } = new List<KBlockBinding>();

        public int CalculatedCurrentEndTime
        {
            get
            {
                if(CurrentProcess == null) return 0;
                return Bindings.Where(bb => bb.Process == CurrentProcess).Select(bb => bb.BlockEndTime).First();
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

        public void Reset()
        {
            IsBlocked = false;
        }

        public int GetSummaryDuration()
        {
            return Bindings.Where(bb => bb.Process.Status != KStates.ProcessState.Ready).Sum(bb => bb.BlockDuration);
        }
    }
}