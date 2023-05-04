namespace ProblemOne
{
    public class KBlock
    {
        public Guid Id { get; set; }
        public int PipelineIndex { get; set; }
        public bool IsBlocked { get; set; } = false;

        public KProcess? CurrentExecutor { get; set; } = null;

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