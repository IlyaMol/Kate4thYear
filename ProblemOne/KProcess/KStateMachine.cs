using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KStateMachineExtensions
    {
        public static KStateMachine AddProcessors(this KStateMachine machine, int procCount)
        {
            for (int iteration = 0; iteration < procCount; iteration++)
                machine.Processors.Add(new KProcessor(iteration));
            return machine;
        }
    }

    public static class KStateMashineExecuteExtensions
    {
        public static void ExecuteAsync(this KProcessor processor, KBlockBinding block)
        {

        }
    }

    public class KStateMachine
    {
        public ICollection<KBlock> Blocks { get; set; } = new List<KBlock>();
        public ICollection<KProcess> Processes { get; private set; } = new List<KProcess>();
        public ICollection<KProcessor> Processors { get; set; } = new List<KProcessor>();

        public static bool TryBuild(in int[,] matrix, int processorCount, out KStateMachine machine)
        {
            machine = new KStateMachine().AddProcessors(processorCount);

            uint thread = 0;

            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                KProcess? process = new(rowIndex);
                machine.Processes.Add(process);

                if (rowIndex % processorCount == 0)
                    thread++;

                for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
                {
                    
                    KBlock? currentBlock = machine.Blocks.FirstOrDefault(b => b.PipelineIndex == columnIndex);
                    if (currentBlock == null)
                    {
                        currentBlock = new KBlock(columnIndex);
                        machine.Blocks.Add(currentBlock);
                    }
                    process.AddBlockBinding(currentBlock, matrix[rowIndex, columnIndex], thread);
                }
            }
            return true;
        }

        HashSet<KProcessor> processors = new();
        public KStateMachine Execute(EExecuteModeType executionMode, EDistributeModeType distributionMode, bool isCombined = true)
        {
            int tickCount = 0;
            ResetStates();
            // одна итерация цикла - один такт машины
            while (Processes.Any(p => p.Status != EProcessState.Done))
            {
                //для начала выполняем блоки на всех процессорах
                processors = Processors.Where(p => p.Status == EProcessorState.Busy).ToHashSet();
                foreach(var processor in processors)
                    processor.DoTick(tickCount);

                //назначаем блоки на незанятые процессоры
                processors = Processors.Where(p => p.Status == EProcessorState.Ready).ToHashSet();
                if(executionMode == EExecuteModeType.Async)
                {

                }
                tickCount++;
            }
            return this;
        }

        public void ResetStates()
        {
            foreach (var block in Blocks)
                block.Reset();
            foreach (var process in Processes)
                process.Reset();
            foreach (var processor in Processors)
                processor.Reset();
        }
    }
}