namespace ProblemOne
{
    public class KProcessor
    {
        public int Index { get; set; }
        public KStatus Status { get; set; }
        public KProcess? CurrentProcess { get; set; }
        public KBlock? CurrentBlock { get; set; }

        public KProcessor()
        {
            Status = KStatus.Idle;
            CurrentProcess = null;
            CurrentBlock = null;
        }

        public static ICollection<KProcessor> CreateBatch(int count)
        {
            ICollection<KProcessor> batch = new List<KProcessor>();
            for (int index = 0; index < count; index++)
                batch.Add(new KProcessor() { Index = index });
            return batch;
        }


    }
}
