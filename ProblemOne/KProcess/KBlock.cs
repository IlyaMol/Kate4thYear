namespace ProblemOne
{
    public class KBlock
    {
        public int CopyCount { get; set; }

        public int PipelineIndex { get; set; }

        public bool IsBlocked
        {
            get 
            { 
                if(CurrentProcesses.Count >= CopyCount) return true;
                return false;
            }
        }

        public ICollection<KProcess> CurrentProcesses { get; set; } = new HashSet<KProcess>();

        public int LastExecutorIndex { get; set; } = -1;

        public ICollection<KBlockBinding> Bindings { get; } = new List<KBlockBinding>();

        public KBlock()
        {
            PipelineIndex = 0;
        }
        public KBlock(int index, int resourceCopyCount = 1)
        {
            PipelineIndex = index;
            CopyCount = resourceCopyCount;
        }

        public void Reset()
        {
            LastExecutorIndex = -1;
            CurrentProcesses = new HashSet<KProcess>();
        }
    }
}