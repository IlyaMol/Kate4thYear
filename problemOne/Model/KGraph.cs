namespace problemOne.Model
{
    public class KGraph
    {
        public Guid Id { get; set; }

        public ICollection<KVertex> Vertices { get; } = new HashSet<KVertex>();
        public ICollection<KEdge> Edges { get; } = new HashSet<KEdge>();

        public void AddEdge(KEdge edge)
        {
            KVertex? targetVertex = Vertices.FirstOrDefault(v => v.Id == edge.From.Id);
            if(targetVertex == null)
            {
                targetVertex = edge.From;
                Vertices.Add(targetVertex);
            }

            if (!Vertices.Any(v => v.Id == edge.To.Id))
                Vertices.Add(edge.To);

            Edges.Add(edge);
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
                        KVertex neighbourVertex = graph.Vertices.FirstOrDefault(v => v.RowIndex == rowIndex && v.ColumnIndex == columnIndex +1);
                        if (neighbourVertex == null)
                            neighbourVertex = new KVertex(rowIndex, columnIndex +1, sourceMatrix[rowIndex, columnIndex +1]);
                        graph.Edges.Add(new KEdge(targetVertex, neighbourVertex));
                    }
                    // bottom neighbour
                    if (rowIndex + 1 < sourceMatrix.GetLength(0))
                    {
                        KVertex neighbourVertex = graph.Vertices.FirstOrDefault(v => v.RowIndex == rowIndex +1 && v.ColumnIndex == columnIndex);
                        if (neighbourVertex == null)
                            neighbourVertex = new KVertex(rowIndex +1, columnIndex, sourceMatrix[rowIndex +1, columnIndex]);
                        graph.Edges.Add(new KEdge(targetVertex, neighbourVertex));
                    }
                }

            return true;
        }

        public void Print(List<Vertex>? path = null)
        {
            int index = 0;
            do
            {
                ICollection<KVertex> verticesRow = Vertices.Where(v => v.RowIndex == index).ToList();
                foreach(KVertex v in verticesRow)
                {
                    Console.Write(v.Weight);
                    if (v != verticesRow.Last())
                        Console.Write(" ");
                }
                Console.WriteLine();
                index++;
            } while (Vertices.Any(v => v.RowIndex >= index));
        }
    }
}
