using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessExtensions
    {
        public static KProcess AddBlockBinding(this KProcess process, KBlock block, int blockDuration)
        {
            process.BlockBindings.Add(new KBlockBinging(block, process, blockDuration));
            return process;
        }
    }

    public class KProcess
    {
        public int Index { get; set; }

        public ICollection<KBlockBinging> BlockBindings { get; } = new List<KBlockBinging>();

        public KProcessor? Executor { get; set; } = null;

        public int LastExecutedBlockIndex { get; set; } = -1;

        public KBlockBinging? NextTask
        {
            get { return BlockBindings.Where(bb => bb.Status != BlockState.Done).FirstOrDefault(); }
        }

        public ProcessState Status
        {
            get
            {
                if (Executor != null) return ProcessState.Binded;
                if (NextTask == null || BlockBindings.All(bb => bb.Status == BlockState.Done)) return ProcessState.Done;
                if (NextTask.Status == BlockState.Busy) return ProcessState.Waiting;
                if (BlockBindings.Any(bb => bb.Status == BlockState.Busy) return ProcessState.Busy;
                return ProcessState.Ready;
            }
        }

        public KProcess(int index)
        {
            Index = index;
        }
    }
}
