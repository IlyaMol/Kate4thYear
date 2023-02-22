namespace problemOne.Model
{
    public class KVertex
    {
        public Guid Id { get; set; }

        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }

        public int Weight { get; set; }

        public KVertex? RNeighbour { get; set; }
        public KVertex? BNeighbour { get; set; }

        public ICollection<KVertex> Neighbours 
        {
            get
            {
                List<KVertex> neighbours = new List<KVertex>();
                if(RNeighbour != null) neighbours.Add(RNeighbour);
                if (BNeighbour != null) neighbours.Add(BNeighbour);
                return neighbours;
            }
        }

        public KVertex(int rowIndex, int columnIndex, int weight = 0)
        {
            Id = Guid.NewGuid();

            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            Weight = weight;
        }
    }
}
