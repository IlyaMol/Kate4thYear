namespace problemOne.Model
{
    public class KEdge
    {
        public Guid Id { get; set; }

        public KVertex From { get; set; }
        public KVertex To { get; set; }

        public int Weight { get; set; }

        public KEdge(KVertex from, KVertex to, int weight = 0) 
        {
            Id = Guid.NewGuid();
            From = from;
            To = to;
            Weight = weight;

            From.AdjacentEdges.Add(this);
        }
    }
}
