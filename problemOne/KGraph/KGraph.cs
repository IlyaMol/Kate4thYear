using ProblemOne.KGraph;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace ProblemOne.Model
{
    public class KGraph
    {
        public Guid Id { get; set; }

        public int RowInMatrix
        {
            get
            {
                if (Vertices.Count == 0) return 0;
                return Vertices.Max(v => v.RowIndex);
            }
        }
        public int ColumnInMatrix
        {
            get
            {
                if (Vertices.Count == 0) return 0;
                return Vertices.Max(v => v.ColumnIndex);
            }
        }
        public ICollection<KVertex> Vertices { get; set; } = new HashSet<KVertex>();

        public KGraph()
        {
            Id = Guid.NewGuid();
        }

        public KVertex ElementAt(int rowIndex, int columnIndex)
        {
            KVertex? vertex = Vertices.FirstOrDefault(v => v.RowIndex == rowIndex && v.ColumnIndex == columnIndex);
            if (vertex == null) { throw new ArgumentOutOfRangeException($"[{rowIndex}, {columnIndex}]"); }
            return vertex;
        }

        public static bool TryBuid(int[,] sourceMatrix, out KGraph graph)
        {
            graph = new KGraph();

            for (int rowIndex = 0; rowIndex < sourceMatrix.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < sourceMatrix.GetLength(1); columnIndex++)
                {
                    KVertex? targetVertex = graph.Vertices.FirstOrDefault(v => v.RowIndex == rowIndex && v.ColumnIndex == columnIndex);
                    if (targetVertex == null)
                    {
                        targetVertex = new KVertex(rowIndex, columnIndex, sourceMatrix[rowIndex, columnIndex]);
                        graph.Vertices.Add(targetVertex);
                    }

                    // right neighbour
                    if (columnIndex + 1 < sourceMatrix.GetLength(1))
                    {
                        KVertex? neighbourVertex = graph.Vertices.FirstOrDefault(v => v.RowIndex == rowIndex && v.ColumnIndex == columnIndex + 1);
                        if (neighbourVertex == null)
                        {
                            neighbourVertex = new KVertex(rowIndex, columnIndex + 1, sourceMatrix[rowIndex, columnIndex + 1]);
                            graph.Vertices.Add(neighbourVertex);
                        }
                        targetVertex.RNeighbour = neighbourVertex;
                    }
                    // bottom neighbour
                    if (rowIndex + 1 < sourceMatrix.GetLength(0))
                    {
                        KVertex? neighbourVertex = graph.Vertices.FirstOrDefault(v => v.RowIndex == rowIndex + 1 && v.ColumnIndex == columnIndex);
                        if (neighbourVertex == null)
                        {
                            neighbourVertex = new KVertex(rowIndex + 1, columnIndex, sourceMatrix[rowIndex + 1, columnIndex]);
                            graph.Vertices.Add(neighbourVertex);
                        }
                        targetVertex.BNeighbour = neighbourVertex;
                    }
                }

            return true;
        }

        public static bool ToMatrix(KGraph sourceGraph, out int[,]? resultMatrix)
        {
            resultMatrix = null;
            if (sourceGraph.Vertices.Count <= 0) return false;

            int rowCount = sourceGraph.Vertices.Max(v => v.RowIndex) + 1;
            int columnCount = sourceGraph.Vertices.Max(v => v.ColumnIndex) + 1;
            resultMatrix = new int[rowCount, columnCount];

            for (int rowIndex = 0; rowIndex < resultMatrix.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < resultMatrix.GetLength(1); columnIndex++)
                {
                    KVertex? vertex = sourceGraph.Vertices
                        .FirstOrDefault(v => v.RowIndex == rowIndex && v.ColumnIndex == columnIndex);
                    if (vertex == null) return false;
                    resultMatrix[rowIndex, columnIndex] = vertex.Weight;
                }
            return true;
        }

        public ConcurrentBag<KPath<KVertex>> CriticalPaths { get; private set; } = new();
        public List<Thread> StartedThreads { get; } = new List<Thread>();
        public Stack<KVertex> VerticesStack { get; } = new();
        public static void GetCriticalPath(KGraph graph, CancellationToken cancellationToken, KVertex? nextVertex = null, KPath<KVertex>? path = null)
        {
            if (graph.Vertices.Count <= 0)
                return;

            bool forceBreak = false;

            if (path == null)
                path = new();

            List<KVertex> visitedVertices = new List<KVertex>();
            if (graph.Vertices.Count <= 0) return;
            if (nextVertex == null)
                nextVertex = graph.Vertices.First();
            graph.VerticesStack.Push(nextVertex);

            // если целевая вершина конечная
            if (graph.Vertices.Last().Id == nextVertex.Id || nextVertex.Neighbours.All(v => v.Weight == 0))
                if (path.Count == 0 || path.Sum(v => v.Weight) <= graph.VerticesStack.Sum(v => v.Weight))
                {
                    path = graph.VerticesStack.FromList<KVertex>();
                    //path.Reverse();
                    // если в списке путей пути меньшей длины чем найденый
                    // обнуляем найденное
                    if (graph.CriticalPaths.Count == 0
                        || path.Sum(v => v.Weight) > graph.CriticalPaths.First().Length)
                    {
                        graph.CriticalPaths = new() { path };
                    } else if (graph.CriticalPaths.Count == 0
                        || path.Sum(v => v.Weight) == graph.CriticalPaths.First().Length)
                        graph.CriticalPaths.Add(path);
                    forceBreak = true;
                }

            if (nextVertex.Neighbours.Count > 0 && !forceBreak)
            {
                // если вершины равновесны - тестим обе
                // иначе идем через самую толстую
                if (nextVertex.Neighbours.All(v => v.Weight == nextVertex.Neighbours.Max(v => v.Weight)))
                    foreach (KVertex testVertex in nextVertex.Neighbours)
                    {
                        visitedVertices.Add(testVertex);
                        GetCriticalPath(graph, cancellationToken, testVertex, path);
                    }
                else
                    GetCriticalPath(graph, cancellationToken, nextVertex.Neighbours.MaxBy(v => v.Weight)!, path);
            }

            KVertex? testVertex1 = graph.VerticesStack.Pop();
            return;
        }
    }
}