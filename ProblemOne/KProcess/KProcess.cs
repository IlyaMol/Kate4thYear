using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessExtensions
    {
        public static KProcess AddBlockBinding(this KProcess process, KBlock block, int blockDuration, uint threadIndex = 0)
        {
            var binding = new KBlockBinding(block, process, blockDuration) { ThreadIndex = threadIndex };
            process.BlockBindings.Add(binding);
            block.Bindings.Add(binding);
            return process;
        }
    }

    public class KProcess
    {
        public int Index { get; set; }
        public int ExecutorIndex { get; set; } = -1;

        public bool IsCurrentlyBinded {  get { return Executor != null; } }

        public ICollection<KBlockBinding> BlockBindings { get; } = new List<KBlockBinding>();

        public KProcessor? Executor { get; set; } = null;

        // блок перехода между потоками
        // для первого в процессе блока - либо null, если до этого потоков нет
        // либо последний исполненный блок для предыдущего потока процесса
        public KBlockBinding? TransitiveBlock { get; set; }

        public KBlockBinding? CurrentTask
        {
            get { return BlockBindings.Where(bb => bb.Process.IsCurrentlyBinded && bb.Status != BlockState.Done).FirstOrDefault(bb => bb.Status == BlockState.Busy); }
        }

        public KBlockBinding? NextTask
        {
            get 
            { 
                if(CurrentTask == null)
                    return BlockBindings.Where(bb => bb.Process.IsCurrentlyBinded && bb.Status != BlockState.Done).FirstOrDefault();
                else
                    return BlockBindings.Where(bb => bb.Process.IsCurrentlyBinded && bb.Status != BlockState.Done).FirstOrDefault(bb => bb.Block.PipelineIndex == CurrentTask.Block.PipelineIndex + 1);
            }
        }

        public KBlockBinding FirstBlock
        {
            get { return BlockBindings.First(); }
        }

        public KBlockBinding LastBlock
        {
            get { return BlockBindings.Last(); }
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
