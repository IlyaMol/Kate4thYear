namespace ProblemOne
{
    public class KStateMachine
    {
        public ICollection<KBlock> Blocks { get; set; } = new List<KBlock>();
        public ICollection<KProcess> Processes { get; private set; } = new List<KProcess>();
        public ICollection<KProcessor> Processors { get; set; } = new List<KProcessor>();

        public static bool TryBuildFromMatrix(in int[,] matrix, out KStateMachine machine)
        {
            machine = new KStateMachine();

            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                KProcess? process = new KProcess(rowIndex);
                machine.Processes.Add(process);

                for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
                {
                    KBlock? currentBlock = machine.Blocks.FirstOrDefault(b => b.PipelineIndex == columnIndex);

                    if (currentBlock == null)
                    {
                        currentBlock = new KBlock(columnIndex);
                        machine.Blocks.Add(currentBlock);
                    }

                    process.AddBlockBinding(currentBlock, matrix[rowIndex, columnIndex]);
                }
            }
            return true;
        }

        public KStateMachine Execute(EProcType procType, bool combined = true)
        {
            // NOTE(wwaffe): one iteration of this while loop = one tick for our machine
            int tickCount = 0;

            while (Processes.Any(p => p.Status != EStatus.Done))
            {
                // check all proceesors if any done it's work
                foreach(var processor in Processors) 
                { 
                    
                }

                KProcess? nextIdleProcess = Processes.FirstOrDefault(p => p.Status == EStatus.Idle);

                // all processes are busy but not done
                if(nextIdleProcess == null) { tickCount++; continue; }

                KBlock? nextBlock = nextIdleProcess.NextBlock;
                if (nextBlock == null) throw new NullReferenceException("No blocks to exec, process stuck in idle state!");

                KProcessor? idlePocessor = Processors.FirstOrDefault(p => p.Status == EStatus.Idle);

                // all processors are busy, continue
                if(idlePocessor == null) { tickCount++; continue; }
                


                tickCount++;
            }

            return this;
        }
    }
}
