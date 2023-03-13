namespace ProblemOne
{
    public class KStateMachine
    {
        public ICollection<KProcess> Processes { get; private set; } = new List<KProcess>();

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
                    }
                }
                threadIndex++;
            }
            return machine;
        }

        public KStateMachine Execute(KProcType procType, bool combined = true)
        {
            // NOTE(wwaffe): one iteration of this while loop = one tick for our machine
            int tickCount = 0;
            int currentThreadIndex = 0;
            List<int> busyBlockIndex = new List<int>();
            foreach (KProcess process in Processes)
                process.Reset();
            while(Processes.Any(p => p.Status != KStatus.Done))
            {


                foreach(KProcess process in Processes)
                {
                    if(process.Status == KStatus.Busy || process.Status == KStatus.Done)
                    {
                        if (process.CurrentBlock != null
                            && process.CurrentBlock.Duration + process.CurrentBlock.StartTime <= tickCount)
                        {
                            int nextBlockIndex = -1;
                            if (combined)
                                if (process.CurrentBlock.ThreadIndex > 0)
                                    nextBlockIndex = process.CurrentBlock.PipelineIndex + 2 ^ process.Index;
                                else
                                    nextBlockIndex = process.CurrentBlock.PipelineIndex;
                            else
                                nextBlockIndex = process.CurrentBlock.PipelineIndex;

                            busyBlockIndex.Remove(process.CurrentBlock.PipelineIndex);
                            process.CurrentBlock.Status = KStatus.Done;
                        }
                    }
                }

                if(!combined)
                    if(Processes
                        .SelectMany(p => p.Blocks)
                        .Where(b => b.ThreadIndex == currentThreadIndex)
                        .All(b => b.Status == KStatus.Done)
                      )
                        currentThreadIndex++;

                foreach (KProcess process in Processes)
                {
                    if (process.Status == KStatus.Idle)
                    {
                        KBlock? nextBlock = process.NextBlock;

                        if (nextBlock != null)
                        {
                            int nextBlockIndex = -1;
                            if (combined)
                                if (nextBlock.ThreadIndex > 0)
                                    nextBlockIndex = nextBlock.PipelineIndex + 2^process.Index;
                                else
                                    nextBlockIndex = nextBlock.PipelineIndex;
                            else
                                nextBlockIndex = nextBlock.PipelineIndex;

                            if (!combined && nextBlock.ThreadIndex != currentThreadIndex) continue;

                            if (!busyBlockIndex.Contains(nextBlockIndex))
                            {
                                process.CurrentBlock = nextBlock;
                                nextBlock.StartTime = tickCount;
                                busyBlockIndex.Add(nextBlockIndex);
                            }
                        }
                        
                    }
                }
                tickCount++;
            }
            return this;
        }
    }
}
