namespace ProblemOne
{
    public class KBlock
    {
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
            PipelineIndex = 0;
        }
        public KBlock(int index)
        {
            PipelineIndex = index;
        }

        public void Reset()
        {
            IsBlocked = false;
            LastExecutorIndex = -1;
        }

        public bool IsCompleted(uint forThread = 0)
        {
            return Bindings.Where(bb => bb.ThreadIndex == forThread).All(bb => bb.Status == KStates.EBlockState.Done);
        }
    }
}