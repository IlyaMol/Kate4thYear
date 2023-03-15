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
                for (int columnIndex = 0; columnIndex < submatrix.GetLength(1); columnIndex++)
                {
                    KProcess? process = machine.Processes.FirstOrDefault(pr => pr.Index == columnIndex);
                    if(process == null)
                    {
                        process = new KProcess() { Index = columnIndex };
                        machine.Processes.Add(process);
                    }

                    for (int rowIndex = 0; rowIndex < submatrix.GetLength(0); rowIndex++)
                    {
                        KBlock block = new KBlock()
                        {
                            ProcessId = process.Id,
                            Duration= submatrix[rowIndex, columnIndex],
                            PipelineIndex= rowIndex,
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
                            int currentBlockIndex = -1;
                            if (combined)
                                if (process.CurrentBlock.ThreadIndex > 0)
                                    currentBlockIndex = process.CurrentBlock.PipelineIndex + (int)Math.Pow(2, process.CurrentBlock.ThreadIndex) + process.CurrentBlock.ThreadIndex;
                                else
                                    currentBlockIndex = process.CurrentBlock.PipelineIndex;
                            else
                                currentBlockIndex = process.CurrentBlock.PipelineIndex;
                            busyBlockIndex.Remove(currentBlockIndex);
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
                            if (!combined && nextBlock.ThreadIndex != currentThreadIndex) continue;

                            switch (procType)
                            {
                                case KProcType.Async:

                                    int nextBlockIndex = -1;
                                    if (combined)
                                        if (nextBlock.ThreadIndex > 0)
                                            nextBlockIndex = nextBlock.PipelineIndex + (int)Math.Pow(2, nextBlock.ThreadIndex) + nextBlock.ThreadIndex;
                                        else
                                            nextBlockIndex = nextBlock.PipelineIndex;
                                    else
                                        nextBlockIndex = nextBlock.PipelineIndex;

                                    if (!busyBlockIndex.Contains(nextBlockIndex))
                                    {
                                        process.CurrentBlock = nextBlock;
                                        nextBlock.StartTime = tickCount;
                                        busyBlockIndex.Add(nextBlockIndex);
                                    }
                                    break;
                                case KProcType.SyncFirst:
                                    KProcess? nextProcess = Processes.FirstOrDefault(p => p.Index == process.Index + 1);
                                    if (nextProcess == null 
                                        || nextProcess.NextBlock == null)
                                        continue;

                                    //if (process.CurrentBlock == null || nextBlock.Duration + tickCount)
                                    //    if (!busyBlockIndex.Contains(nextBlock.PipelineIndex))
                                    //    {
                                    //        process.CurrentBlock = nextBlock;
                                    //        nextBlock.StartTime = tickCount;
                                    //        busyBlockIndex.Add(nextBlock.PipelineIndex);
                                    //    }
                                    break;
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
