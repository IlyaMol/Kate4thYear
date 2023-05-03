namespace ProblemOne
{
    public class KBlock
    {
        public Guid Id { get; set; }

        public ICollection<KBlockBinging> Bindings { get; } = new HashSet<KBlockBinging>(); 
        public EStatus Status { get; set; }

        public KBlock()
        {
            Id = Guid.NewGuid();
        }

        public void Reset()
        {
            Status = EStatus.Idle;
            foreach(var blockBinding in Bindings)
            {
                blockBinding.BlockStartTime = 0;
            }
        }
    }
}