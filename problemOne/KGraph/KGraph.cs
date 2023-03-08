using ProblemOne.KGraph;
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
                    if(targetVertex == null)
                    {
                        targetVertex = new KVertex(rowIndex, columnIndex, sourceMatrix[rowIndex, columnIndex]);
                        graph.Vertices.Add(targetVertex);
                    }

                    // right neighbour
                    if(columnIndex + 1 < sourceMatrix.GetLength(1))
                    {
                        KVertex? neighbourVertex = graph.Vertices.FirstOrDefault(v => v.RowIndex == rowIndex && v.ColumnIndex == columnIndex +1);
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
                        KVertex? neighbourVertex = graph.Vertices.FirstOrDefault(v => v.RowIndex == rowIndex +1 && v.ColumnIndex == columnIndex);
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

            int rowCount = sourceGraph.Vertices.Max(v => v.RowIndex) +1;
            int columnCount = sourceGraph.Vertices.Max(v => v.ColumnIndex) +1;
            resultMatrix = new int[rowCount, columnCount];

            for(int rowIndex = 0; rowIndex < resultMatrix.GetLength(0); rowIndex++)
                for(int columnIndex = 0; columnIndex < resultMatrix.GetLength(1); columnIndex++)
                {
                    KVertex? vertex = sourceGraph.Vertices
                        .FirstOrDefault(v => v.RowIndex == rowIndex && v.ColumnIndex == columnIndex);
                    if (vertex == null) return false;
                    resultMatrix[rowIndex, columnIndex] = vertex.Weight;
                }
            return true;
        }

        private Stack<KVertex> verticesStack = new();
        private List<KVertex> criticalPath = new();
        private List<List<KVertex>> criticalPaths = new();
        public List<List<KVertex>> GetCriticalPath(KVertex? vertex = null)
        {
            bool forceBreak = false;

            List<KVertex> visitedVertices = new List<KVertex>();
            if (Vertices.Count <= 0) return criticalPaths;
            if (vertex == null)
                vertex = Vertices.First();
            verticesStack.Push(vertex);

            // если целевая вершина конечная
            if (Vertices.Last().Id == vertex.Id ||  vertex.Neighbours.All(v => v.Weight == 0))
                if (criticalPath.Count == 0 || criticalPath.Sum(v => v.Weight) <= verticesStack.Sum(v => v.Weight))
                {
                    criticalPath = verticesStack.ToList();
                    criticalPath.Reverse();
                    // если в списке путей пути меньшей длины чем найденый
                    // обнуляем найденное
                    if (criticalPaths.Count == 0 
                        || criticalPath.Sum(v => v.Weight) > criticalPaths.First().Sum(v => v.Weight))
                    {
                        criticalPaths = new();
                        criticalPaths.Add(criticalPath);
                    } else if(criticalPaths.Count == 0
                        || criticalPath.Sum(v => v.Weight) == criticalPaths.First().Sum(v => v.Weight))
                        criticalPaths.Add(criticalPath);
                    forceBreak = true;
                }

            if (vertex.Neighbours.Count > 0 && !forceBreak)
            {
                // если вершины равновесны - тестим обе
                // иначе идем через самую толстую
                if (vertex.Neighbours.All(v => v.Weight == vertex.Neighbours.Max(v => v.Weight)))
                    foreach (KVertex testVertex in vertex.Neighbours)
                    {
                        visitedVertices.Add(testVertex);
                        GetCriticalPath(testVertex);
                    }
                else
                    GetCriticalPath(vertex.Neighbours.MaxBy(v => v.Weight));
            }

            KVertex? testVertex1 = verticesStack.Pop();
            return criticalPaths;
        }

        public static ICollection<KPath<KVertex>> FindCriticalPath(in KGraph graph)
        {
            Stack<KVertex> verticesStack = new();



        }
    }
}