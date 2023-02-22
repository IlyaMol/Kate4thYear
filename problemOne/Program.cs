using problemOne.Model;
using System.Collections.Concurrent;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrixTest = new int[12, 12]
        {
            { 1,4,3,1 ,1,4,3,1, 1,4,3,1 },
            { 3,2,4,3 ,3,2,4,3, 3,2,4,3 },
            { 1,2,4,2 ,1,2,4,2, 1,2,4,2 },
            { 3,2,4,1 ,3,2,4,1, 3,2,4,1 },

            { 3,1,2,3 ,3,1,2,3, 0,0,0,0 },
            { 4,3,3,1 ,4,3,3,1, 0,0,0,0 },
            { 4,2,4,2 ,4,2,4,2, 0,0,0,0 },
            { 3,3,1,2 ,3,3,1,2, 0,0,0,0 },

            { 2,1,4,3 ,0,0,0,0, 0,0,0,0 },
            { 2,2,2,1 ,0,0,0,0, 0,0,0,0 },
            { 3,4,2,1 ,0,0,0,0, 0,0,0,0 },
            { 4,2,3,1 ,0,0,0,0, 0,0,0,0 },
        };//44
        int[,] matrixTest2 = new int[9, 12]
        {
            { 1,2,3,1, 1,2,1,1, 3,2,1,1 },
            { 2,3,1,2, 2,1,1,2, 1,1,3,2 },
            { 3,1,2,1, 2,1,3,1, 2,1,2,3 },

            { 1,2,1,1, 3,2,1,1, 0,0,0,0 },
            { 2,1,1,2, 1,1,3,2, 0,0,0,0 },
            { 2,1,3,1, 2,1,2,3, 0,0,0,0 },

            { 3,2,1,1, 0,0,0,0, 0,0,0,0 },
            { 1,1,3,2, 0,0,0,0, 0,0,0,0 },
            { 2,1,2,3, 0,0,0,0, 0,0,0,0 }
        };//27
        int[,] matrixtest3 = new int[8, 12]
        {
            { 3,2,1,4, 2,1,1,3, 2,2,3,2 },
            { 1,2,3,1, 1,3,1,1, 1,2,1,5 },
            { 4,1,3,2, 4,3,3,1, 0,0,0,0 },

            { 2,1,1,3, 2,2,3,2, 0,0,0,0 },
            { 1,3,1,1, 1,2,1,5, 0,0,0,0 },
            { 4,3,3,1, 0,0,0,0, 0,0,0,0 },

            { 2,2,3,2, 0,0,0,0, 0,0,0,0 },
            { 1,2,1,5, 0,0,0,0, 0,0,0,0 },
        };//35

        int[,] matrix = new int[4, 4]
        {
            { 2,1,4,1 },
            { 1,3,2,3 },
            { 2,4,1,2 },
            { 3,2,3,1 }
        };//16

        KGraph? graph;
        KGraph.TryBuid(ref matrixTest2, out graph);

        graph.Print();

        List<KVertex> criticalPath = graph.GetCriticalPath();

        graph.Print(criticalPath);

        Console.WriteLine($"Critical path length: {criticalPath.Sum(v => v.Weight)}");
    }
    /*
    private static void GetCriticalPathLength(List<Vertex> graph, Vertex? startVertex = null)
    {
        Vertex? vStart;
        Vertex? testVertex;

        if (startVertex == null)
            vStart = graph.First();
        else
            vStart = startVertex;

        path.Push(vStart);

        if(!vStart.IsTarget)
            vStart.Visited = true;

        Console.Write($"Path now: ");
        foreach (int i in path.Select(v => v.Weight))
            Console.Write(i);
        Console.WriteLine();
        //Console.WriteLine($"Testing verticie: row: {vStart.rowPosition}, col: {vStart.columnPosition}, weight: {vStart.Weight}");

        if(vStart.Neighbours.Count > 0)
        {
            testVertex = vStart.Neighbours.Where(vN => !vN!.Visited).MaxBy(vN => vN!.Weight);
            if (testVertex == null) return;
            GetCriticalPathLength(graph, testVertex);
        }
        
        if(vStart.IsTarget)
            pathLengthFounded.Add(path.Sum(v => v.Weight));

        vStart = path.Pop().Neighbours.FirstOrDefault(v => !v.Visited);

        if (vStart == null) return;

        testVertex = vStart.Neighbours.Where(vN => !vN!.Visited).MaxBy(vN => vN!.Weight);

        if (testVertex == null) return;

        GetCriticalPathLength(graph, testVertex);
    }
    */
}