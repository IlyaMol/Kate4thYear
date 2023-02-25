using problemOne.Model;

internal class Program
{ 
    private static void Main(string[] args)
    {
        int processorCount = 4;
        
        int[,] matrixTest = new int[12, 4]
        {
            { 1,4,3,1 },
            { 3,2,4,3 },
            { 1,2,4,2 },
            { 3,2,4,1 },

            { 3,1,2,3 },
            { 4,3,3,1 },
            { 4,2,4,2 },
            { 3,3,1,2 },

            { 2,1,4,3 },
            { 2,2,2,1 },
            { 3,4,2,1 },
            { 4,2,3,1 },
        };//44
        int[,] matrixTest2 = new int[9, 4]
        {
            { 1,2,3,1 },
            { 2,3,1,2 },
            { 3,1,2,1 },
                      
            { 1,2,1,1 },
            { 2,1,1,2 },
            { 2,1,3,1 },
                      
            { 3,2,1,1 },
            { 1,1,3,2 },
            { 2,1,2,3 }
        };//27
        int[,] matrixtest3 = new int[8, 4]
        {
            { 3,2,1,4 },
            { 1,2,3,1 },
            { 4,1,3,2 },
                      
            { 2,1,1,3 },
            { 1,3,1,1 },
            { 4,3,3,1 },
                      
            { 2,2,3,2 },
            { 1,2,1,5 },
        };//35

        int[,] matrix = new int[4, 4]
        {
            { 2,1,4,1 },
            { 1,3,2,3 },
            { 2,4,1,2 },
            { 3,2,3,1 }
        };//16

        KGraph? graph;
        int[,] preparedMatrix = KGraph.PrepareMatrix(matrixTest, processorCount);
        KGraph.TryBuid(ref preparedMatrix, out graph);

        graph.Print();

        List<KVertex> criticalPath = graph.GetCriticalPath();

        graph.Print(criticalPath);

        Console.WriteLine($"Critical path length: {criticalPath.Sum(v => v.Weight)}");
    }
}