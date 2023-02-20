namespace problemOne.Model
{
    public class KVertex
    {
        public Guid Id { get; set; }

        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }

        public int Weight { get; set; }

        public ICollection<KEdge> AdjacentEdges { get; private set; } = new HashSet<KEdge>();

        public ICollection<KVertex> Neighbours 
        {
            get
            {
                return AdjacentEdges.Select(aE => aE.To).ToList();
            }
        }

        public KVertex(int rowIndex, int columnIndex, int weight = 0)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            Weight = weight;
        }
    }
}
