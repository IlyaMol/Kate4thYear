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
        public int LastExecutedBlock { get; set; } = -1;

        public int Index { get; set; }
        public int ExecutorIndex { get; set; } = -1;
        
        public ICollection<KBlockBinding> BlockBindings { get; } = new List<KBlockBinding>();

        // блок перехода между потоками
        // для первого в процессе блока - либо null, если до этого потоков нет
        // либо последний исполненный блок для предыдущего потока процесса
        // public KBlockBinding? TransitiveBlock { get; set; } = null;

        public IEnumerable<KBlockBinding> CurrentTasks
        {
            get { return BlockBindings.Where(bb => bb.Status == EBlockState.Busy); }
        }

        public KBlockBinding FirstBlock
        {
            get { return BlockBindings.First(); }
        }

        public KBlockBinding LastBlock
        {
            get { return BlockBindings.Last(); }
        }

        public KBlockBinding? NextBlock
        {
            // выдаем блоки по порядку
            get 
            {
                return BlockBindings.Where(bb => bb.Block.PipelineIndex == LastExecutedBlock + 1).FirstOrDefault();
            }
        }

        public EProcessState Status
        {
            get
            {
                if (BlockBindings.All(bb => bb.Status == EBlockState.Done)) return EProcessState.Done;
                if (BlockBindings.Any(bb => bb.Status == EBlockState.Busy)) return EProcessState.Busy;
                if (BlockBindings.All(bb => bb.Status == EBlockState.Ready)) return EProcessState.Idle;
                if (BlockBindings.Any(bb => bb.Status == EBlockState.Binded)) return EProcessState.Waiting;
                if (BlockBindings.Any(bb => bb.Status == EBlockState.Ready)) return EProcessState.Ready;
                return EProcessState.Ready;
            }
        }

        public KProcess(int index)
        {
            Index = index;
        }

        public void Reset()
        {
            ExecutorIndex = -1;
            LastExecutedBlock = -1;
            //TransitiveBlock = null;
            foreach(var blockBindings in BlockBindings)
                blockBindings.Reset();
        }
    }
}
