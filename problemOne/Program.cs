﻿using problemOne.Model;

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
}