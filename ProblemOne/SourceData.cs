namespace ProblemOne
{
    public class SourceData
    {
        public int ProcessorCount { get; set; }
        public bool BulidCombined { get; set; }
        public float DrawingScale { get; set; }
        public int BlockCount { get; set; }

        public int[] Data { get; set; } = new int[4];
    }
}
