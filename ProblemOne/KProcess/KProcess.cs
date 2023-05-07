using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessExtensions
    {
        public static KProcess AddBlockBinding(this KProcess process, KBlock block, int blockDuration)
        {
            var binding = new KBlockBinding(block, process, blockDuration);
            process.BlockBindings.Add(binding);
            block.Bindings.Add(binding);
            return process;
        }
    }

    public class KProcess
    {
        public int Index { get; set; }
        public int ExecutorIndex { get; set; } = -1;

        public ICollection<KBlockBinding> BlockBindings { get; } = new List<KBlockBinding>();

        public KProcessor? Executor { get; set; } = null;

        //public int LastExecutedBlockIndex { get; set; } = -1;

        public KBlockBinding? CurrentTask
        {
            get { return BlockBindings.Where(bb => bb.Status != BlockState.Done).FirstOrDefault(bb => bb.Status == BlockState.Busy); }
        }

        public KBlockBinding? NextTask
        {
            get 
            { 
                if(CurrentTask == null)
                    return BlockBindings.Where(bb => bb.Status != BlockState.Done).FirstOrDefault();
                else
                    return BlockBindings.Where(bb => bb.Status != BlockState.Done).FirstOrDefault(bb => bb.Block.PipelineIndex == CurrentTask.Block.PipelineIndex + 1);
            }
        }

        public ProcessState Status
        {
            get
            {
                if (BlockBindings.All(bb => bb.Status == BlockState.Done)) return ProcessState.Done;
                if (Executor == null) return ProcessState.Ready;
                if (CurrentTask != null && CurrentTask.Status == BlockState.Busy) return ProcessState.Busy;
                if (NextTask != null && NextTask.Status == BlockState.Waiting) return ProcessState.Waiting;
                if (CurrentTask ==  null) return ProcessState.Idle;
                if (Executor != null) return ProcessState.Binded;
                
                return ProcessState.Undefined;
            }
        }

        public KProcess(int index)
        {
            Index = index;
        }

        public void Reset()
        {
            ExecutorIndex = -1;
            Executor = null;
            foreach(var blockBindings in BlockBindings)
                blockBindings.Reset();
        }
    }
}
