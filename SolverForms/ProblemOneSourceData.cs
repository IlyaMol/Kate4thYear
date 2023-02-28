namespace SolverForms
{
    public class ProblemOneSourceData
    {
        public int ProcessorCount { get; set; }
        public int ProcessCount { get; set; }
        public int BlockCount { get; set; }

        public int[,] ExecMatrix { get; set; } = new int[0,0];
    }
}
