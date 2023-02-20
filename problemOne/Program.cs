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
        KGraph.TryBuid(ref matrix, out graph);

        graph.Print();
    }

    private static bool TryBuildGraph(int[,] matrix, out List<Vertex> vertexes)
    {
        int matrixRowCount = matrix.GetLength(0);
        int matrixColumnCount = matrix.GetLength(1);

        // формирование массива вершин
        vertexes = new List<Vertex>();
        for (int row = 0; row < matrixRowCount; row++)
            for (int column = 0; column < matrixColumnCount; column++)
            {
                Vertex? v = vertexes.FirstOrDefault(v => v.rowPosition == row && v.columnPosition == column);
                if (v == null)
                {
                    v = new Vertex
                    {
                        rowPosition = row,
                        columnPosition = column,
                        Weight = matrix[row, column]
                    };
                    vertexes.Add(v);
                }

                if (row == matrixRowCount - 1
                       && column == matrixColumnCount - 1)
                    v.IsTarget = true;

                Vertex? vN = null;
                // right neighbour
                if (row + 1 < matrixRowCount)
                {
                    vN = vertexes.FirstOrDefault(v => v.rowPosition == row + 1 && v.columnPosition == column);
                    if (vN == null)
                    {
                        vN = new Vertex
                        {
                            rowPosition = row + 1,
                            columnPosition = column,
                            Weight = matrix[row + 1, column]
                        };
                        vertexes.Add(vN);
                    }
                    v.Neighbours.Add(vN);
                }

                // bottom neighbour
                if (column + 1 < matrixColumnCount)
                {
                    vN = vertexes.FirstOrDefault(v => v.rowPosition == row && v.columnPosition == column + 1);
                    if (vN == null)
                    {
                        vN = new Vertex
                        {
                            rowPosition = row,
                            columnPosition = column + 1,
                            Weight = matrix[row, column + 1]
                        };
                        vertexes.Add(vN);
                    }
                    v.Neighbours.Add(vN);
                }
            }
        return true;
    }

    static List<int> pathLengthFounded = new List<int>();
    static Stack<Vertex> path = new Stack<Vertex>();
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
}

public class Vertex
{
    public List<Vertex?> Neighbours { get; set; } = new List<Vertex?>();
    
    public int rowPosition { get; set; } = 0;
    public int columnPosition { get; set; } = 0;
    public int Weight { get; set; } = 0;

    public bool Visited { get; set; } = false;
    public bool IsTarget { get; set; } = false;

    public override string ToString()
    {
        return $"Vertex weight: {Weight}; coord: r-{rowPosition}, c-{columnPosition}; Neib count {Neighbours.Count}.";
    }
}