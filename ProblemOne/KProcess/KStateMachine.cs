using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace ProblemOne
{
    public enum KProcType
    {
        None,
        Async,
        SyncFirst,
        SyncSecond
    }

    public class KStateMachine
    {
        public ICollection<KProcess> Processes { get; private set; } = new List<KProcess>();
        public ICollection<KBlock> Blocks { get; private set; } = new List<KBlock>();

        public KProcType LastExecuteType { get; private set; } = KProcType.None;

        public static KStateMachine BuildFromMatrix(in ICollection<int[,]> subMatrixArgs)
        {
            KStateMachine machine= new KStateMachine();

            int threadIndex = 0;
            foreach(int[,] submatrix in subMatrixArgs)
            {
                for (int rowIndex = 0; rowIndex< submatrix.GetLength(0); rowIndex++)
                {
                    KProcess? process = machine.Processes.FirstOrDefault(pr => pr.Index == rowIndex);
                    if(process == null)
                    {
                        process = new KProcess() { Index = rowIndex };
                        machine.Processes.Add(process);
                    }

                    for (int columnIndex = 0; columnIndex < submatrix.GetLength(1); columnIndex++)
                    {
                        KBlock block = new KBlock()
                        {
                            ProcessId = process.Id,
                            Duration= submatrix[rowIndex, columnIndex],
                            PipelineIndex= columnIndex,
                            ThreadIndex= threadIndex
                        };
                        process.Blocks.Add(block);
                        machine.Blocks.Add(block);
                    }
                }
                threadIndex++;
            }

            return machine;
        }

        public bool Execute(KProcType procType, bool combined = true)
        {
            Reset();
            // NOTE(wwaffe): one iteration of this while loop = one tick for our machine
            int tickCount = 0;
            int currentThreadIndex = 0;
            List<int> busyBlockIndex = new List<int>();
            while(Processes.Any(p => p.Status != KStatus.Done))
            {
                foreach(KProcess process in Processes)
                {
                    if(process.Status == KStatus.Busy || process.Status == KStatus.Done)
                    {
                        if (process.CurrentBlock != null
                            && process.CurrentBlock.Duration + process.CurrentBlock.StartTime <= tickCount)
                        {
                            busyBlockIndex.Remove(process.CurrentBlock.PipelineIndex);
                            process.CurrentBlock.Status = KStatus.Done;
                        }
                    }
                }

                if(!combined)
                    if (Processes.SelectMany(p => p.Blocks).Where(b => b.ThreadIndex == currentThreadIndex).All(b => b.Status == KStatus.Done)) currentThreadIndex++;

                foreach (KProcess process in Processes)
                {
                    if (process.Status == KStatus.Idle)
                    {
                        KBlock? nexBlock = process.NextBlock;
                        if (nexBlock != null)
                        {
                            if (!combined && nexBlock.ThreadIndex != currentThreadIndex) continue;

                            if (!busyBlockIndex.Contains(nexBlock.PipelineIndex))
                            {
                                process.CurrentBlock = nexBlock;
                                nexBlock.StartTime = tickCount;
                                busyBlockIndex.Add(nexBlock.PipelineIndex);
                            }
                        }
                        
                    }
                }
                tickCount++;
            }
            LastExecuteType = procType;
            return true;
        }

        public void Reset()
        {
            foreach (KBlock block in Blocks)
                if (block.Status != KStatus.Idle)
                    block.Status = KStatus.Idle;
        }
    }
}
