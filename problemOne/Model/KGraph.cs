namespace problemOne.Model
{
    public class KGraph
    {
        public Guid Id { get; set; }

        public ICollection<KVertex> Vertices { get; } = new HashSet<KVertex>();

        public static int[,] PrepareMatrix(int[,] matrix, int processorCount)
        {
            // matrix segmentation --->
            Dictionary<int, int[,]> subMatrixDict = new();
            int blockCount = matrix.GetLength(1);

            int subMatrixIndex = 0;
            int subMatrixRowIndex = 0;
            int subMatrixColumnIndex = 0;
            var subMatrix = new int[processorCount, blockCount];
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
                {
                    if (subMatrixRowIndex < processorCount)
                    {
                        subMatrix[subMatrixRowIndex, columnIndex] = matrix[rowIndex, columnIndex];
                    }
                    else
                    {
                        subMatrixDict.Add(subMatrixIndex, subMatrix);
                        subMatrixIndex++;
                        subMatrixRowIndex = 0;
                        subMatrix = new int[processorCount, blockCount];
                        subMatrix[subMatrixRowIndex, columnIndex] = matrix[rowIndex, columnIndex];
                    }
                }
                subMatrixRowIndex++;
            }
            subMatrixDict.Add(subMatrixIndex, subMatrix);
            subMatrix = new int[processorCount, blockCount];
            // <---

            // prepare matrix using Dictionary<int, int[,]> --->
            int resultMatrixRowCount = processorCount * subMatrixDict.Values.First().GetLength(0);
            int resultMatrixColumnCount = subMatrixDict.Values.First().GetLength(1) * (subMatrixDict.Values.Count);
            int[,] resultMatrix = new int[resultMatrixRowCount, resultMatrixColumnCount];

            int[] ignorePattern = new int[subMatrixDict.Values.Count];
            for (int elementIndex = 0; elementIndex < ignorePattern.Length; elementIndex++)
                ignorePattern[elementIndex] = 999;

            subMatrixIndex = 0;
            subMatrixRowIndex = 0;
            for (int rowIndex = 0; rowIndex < resultMatrix.GetLength(0); rowIndex++)
            {

                if (subMatrixRowIndex >= subMatrixDict[subMatrixIndex].GetLength(0))
                {
                    subMatrixIndex++;
                    subMatrixRowIndex = 0;
                }

                for (int columnindex = 0; columnindex < resultMatrix.GetLength(1); columnindex++)
                {
                    if (subMatrixColumnIndex >= subMatrixDict[subMatrixIndex].GetLength(1))
                    {
                        subMatrixIndex++;
                        subMatrixColumnIndex = 0;
                    }

                    if (subMatrixIndex >= subMatrixDict.Values.Count)
                    {
                        var notIgnoringSubMatrix = subMatrixDict.Where(kvp => !ignorePattern.Contains(kvp.Key));
                        int indexToIgnore = notIgnoringSubMatrix.First().Key;
                        for (int elementIndex = 0; elementIndex < ignorePattern.Length; elementIndex++)
                            if (ignorePattern[elementIndex] == 999)
                            {
                                ignorePattern[elementIndex] = indexToIgnore;
                                subMatrixDict.Remove(0);
                                subMatrixDict.Add(subMatrixDict.Keys.Max() + 1, subMatrix);
                                break;
                            }
                        break;
                    }

                    resultMatrix[rowIndex, columnindex] = subMatrixDict[subMatrixIndex][subMatrixRowIndex, subMatrixColumnIndex];
                    subMatrixColumnIndex++;
                }
                subMatrixRowIndex++;

                for (int newMatrixIndex = 0; newMatrixIndex < subMatrixDict.Keys.Max(); newMatrixIndex++)
                    if (ignorePattern.Contains(newMatrixIndex)) continue;
                    else
                    {
                        subMatrixIndex = newMatrixIndex;
                        break;
                    }
                subMatrixColumnIndex = 0;

                PrintMatrix(resultMatrix);
            }
            //<---
            return resultMatrix;
        }

        public static bool TryBuid(ref int[,] sourceMatrix, out KGraph graph)
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

        private Stack<KVertex> verticesStack = new();
        private List<KVertex> criticalPath = new();
        public List<KVertex> GetCriticalPath(KVertex? vertex = null)
        {
            bool forceBreak = false;

            List<KVertex> visitedVertices = new List<KVertex>();

            if (vertex == null)
                vertex = Vertices.First();
            verticesStack.Push(vertex);

            // если целевая вершина конечная
            if (Vertices.Last().Id == vertex.Id ||  vertex.Neighbours.All(v => v.Weight == 0))
                if (criticalPath.Count == 0 || criticalPath.Sum(v => v.Weight) <= verticesStack.Sum(v => v.Weight))
                {
                    criticalPath = verticesStack.ToList();
                    criticalPath.Reverse();
                    forceBreak = true;

                    if (criticalPath.Count == 0 || criticalPath.Sum(v => v.Weight) <= verticesStack.Sum(v => v.Weight))
                        Print(criticalPath);
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
            return criticalPath;
        }

        public void Print(List<KVertex>? path = null)
        {
            Console.Clear();
            int index = 0;
            do
            {
                ICollection<KVertex> verticesRow = Vertices.Where(v => v.RowIndex == index).ToList();
                foreach(KVertex v in verticesRow)
                {
                    if (path != null && path.Any(vt => vt.Id == v.Id))
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(v.Weight);

                    Console.ForegroundColor = ConsoleColor.White;

                    if (v != verticesRow.Last())
                        Console.Write(" ");
                }
                Console.WriteLine();
                index++;
            } while (Vertices.Any(v => v.RowIndex >= index));
            Thread.Sleep(100);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            Console.Clear();
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
                {
                    Console.Write(matrix[rowIndex, columnIndex] + " ");
                }
                Console.WriteLine();
            }
                
        }
    }
}
