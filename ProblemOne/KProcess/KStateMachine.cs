using ProblemOne.KStates;
using System.Diagnostics;

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

    public class KStateMachine
    {
        public ICollection<KBlock> Blocks { get; set; } = new List<KBlock>();
        public ICollection<KProcess> Processes { get; private set; } = new List<KProcess>();
        public ICollection<KProcessor> Processors { get; set; } = new List<KProcessor>();

        //processor/processes
        private Dictionary<int, int> ProcessorBindings { get; } = new Dictionary<int, int>();

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
                if (tickCount == 8)
                {

                }
                //для начала выполняем блоки на всех процессорах
                processors = Processors.Where(p => p.Status == EProcessorState.Busy).ToHashSet();
                foreach(var processor in processors)
                    processor.DoTick(tickCount);

                //назначаем блоки на незанятые процессоры
                processors = Processors.Where(p => p.Status == EProcessorState.Ready).ToHashSet();
                if(executionMode == EExecuteModeType.Async)
                {
                    foreach(var processor in processors)
                    {
                        switch (executionMode)
                        {
                            case EExecuteModeType.Async:
                                BindNextBlockAsync(processor, distributionMode);
                                break;
                        }
                    }
                }

                //для начала выполняем блоки на всех процессорах
                processors = Processors.Where(p => p.Status == EProcessorState.Busy).ToHashSet();
                foreach (var processor in processors)
                    processor.DoTick(tickCount);

                tickCount++;
            }
            return this;
        }

        public void ResetStates()
        {
            ProcessorBindings.Clear();

            foreach (var block in Blocks)
                block.Reset();
            foreach (var process in Processes)
                process.Reset();
            foreach (var processor in Processors)
                processor.Reset();
        }

        private void BindNextBlockAsync(KProcessor processor, EDistributeModeType distributionMode)
        {
            KProcess? targetProcess = GetProcess(processor.Index, distributionMode);

            if (targetProcess == null) return;

            KBlockBinding? nextBlock = targetProcess.NextBlock;

            if (nextBlock == null) return;

            if (distributionMode == EDistributeModeType.Distributed)
                if (!ProcessorBindings.ContainsKey(processor.Index))
                    ProcessorBindings.Add(processor.Index, nextBlock.Block.PipelineIndex);
                   
            if(targetProcess?.Index == 3 && nextBlock.Block.PipelineIndex == 0)
            {

            }

            processor.BindBlock(nextBlock);
        }

        private KProcess? GetProcess(int processorIndex, EDistributeModeType distributionMode)
        {
            KProcess? currentProcess = null;
            IEnumerable<KProcess> processes = Processes.Where(p => p.Status != EProcessState.Done);

            // для сосредоточенного режима выбираем процесс для процессора
            if (distributionMode == EDistributeModeType.Centralized)
                if (ProcessorBindings.ContainsKey(processorIndex))
                {
                    var currentProcessIndex = ProcessorBindings[processorIndex];
                    currentProcess = processes.FirstOrDefault(p => p.Index == currentProcessIndex);

                    // чистим мусор в привязках
                    if (currentProcess == null)
                        ProcessorBindings.Remove(processorIndex);
                    else
                        return currentProcess;
                }

            if (distributionMode == EDistributeModeType.Distributed)
            {
                if (ProcessorBindings.ContainsKey(processorIndex))
                {
                    var currentBlockIndex = ProcessorBindings[processorIndex];

                    currentProcess = processes.Where(p => p.Status != EProcessState.Waiting && p.Status != EProcessState.Busy && p.NextBlock != null)
                        .FirstOrDefault(p => p.NextBlock!.Block.PipelineIndex == currentBlockIndex);

                    return currentProcess;
                }
            }

            processes = processes.Where(p => (p.Status == EProcessState.Ready
                                               || p.Status == EProcessState.Idle));

            if (distributionMode == EDistributeModeType.Centralized)
            {
                currentProcess = processes.FirstOrDefault(p => !ProcessorBindings.Values.Contains(p.Index));
                if (currentProcess != null)
                ProcessorBindings.Add(processorIndex, currentProcess.Index);
            }

            if (distributionMode == EDistributeModeType.Distributed)
            {
                currentProcess = processes.Where(p => p.Status != EProcessState.Waiting && p.Status != EProcessState.Busy && p.NextBlock != null)
                    .FirstOrDefault(p => !ProcessorBindings.Values.Contains(p.NextBlock!.Block.PipelineIndex));
            }

            if (currentProcess != null)
                return currentProcess;
            else
                return null;
        }
    }
}