namespace ProblemOne
{
    public static class KStateMachineExtensions
    {
        public static KStateMachine AddProcessors(this KStateMachine machine, int procCount)
        {
            for (int iteration = 0; iteration < procCount; iteration++)
                machine.Processors.Add(new KProcessor());
            return machine;
        }
    }

    public class KStateMachine
    {
        public ICollection<KBlock> Blocks { get; set; } = new List<KBlock>();
        public ICollection<KProcess> Processes { get; private set; } = new List<KProcess>();
        public ICollection<KProcessor> Processors { get; set; } = new List<KProcessor>();

        public static bool TryBuildFromMatrix(in int[,] matrix, int processorCount, out KStateMachine machine)
        {
            machine = new KStateMachine().AddProcessors(processorCount);

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

            while (Processes.Any(p => p.Status != EProcessStatus.Done))
            {
                // назначаем свободным процессорам незанятые процессы по порядку
                // либо превому освободившемуся процессору, первый доступный процесс
                foreach (KProcessor processor in Processors.Where(p => p.Status == EProcStatus.Idle).ToList())
                    processor.BindProcess(Processes.FirstOrDefault(p => p.Status == EProcessStatus.Ready));
                
                // пробуем запустить все ожидающие процессы
                foreach(var processor in Processors)
                    if(processor.Status == EProcStatus.Ready)
                        processor.ExecuteNext(tickCount);

                tickCount++;
            }

            return this;
        }
    }
}
