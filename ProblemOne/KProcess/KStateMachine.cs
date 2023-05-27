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
        public int CurrentTick { get; set; }
        public ICollection<KBlock> Blocks { get; set; } = new List<KBlock>();
        public ICollection<KProcess> Processes { get; private set; } = new List<KProcess>();
        public ICollection<KProcessor> Processors { get; set; } = new List<KProcessor>();

        // processor/process(block)
        private Dictionary<int, int> ProcessorLeases { get; } = new Dictionary<int, int>();

        // Тут менять ничего не нужно.
        public static bool TryBuild(in int[,] matrix, int processorCount, int resourceCopyCount, out KStateMachine machine)
        {
            machine = new KStateMachine().AddProcessors(processorCount);

            uint thread = 0;

            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                if (rowIndex % processorCount == 0)
                    thread++;

                KProcess? process = new(rowIndex, machine) { ThreadIndex = thread };
                machine.Processes.Add(process);

                for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
                {
                    
                    KBlock? currentBlock = machine.Blocks.FirstOrDefault(b => b.PipelineIndex == columnIndex);
                    if (currentBlock == null)
                    {
                        currentBlock = new KBlock(columnIndex, resourceCopyCount);
                        machine.Blocks.Add(currentBlock);
                    }
                    process.AddBlockBinding(currentBlock, machine, matrix[rowIndex, columnIndex], thread);
                }
            }
            return true;
        }

        public KStateMachine Execute(EExecuteModeType executionMode, EDistributeModeType distributionMode, bool isCombined = true)
        {
            CurrentTick = 0;
            HashSet<KProcessor> processors = new();
            ResetStates();

            // одна итерация цикла - один такт машины
            while (Processes.Any(p => p.Status != EProcessState.Done))
            {
                // для начала выполняем блоки на всех процессорах
                DoTick(executionMode, distributionMode, CurrentTick);

                // назначаем блоки на незанятые процессоры
                processors = Processors.Where(p => p.Status == EProcessorState.Ready).ToHashSet();
                foreach(var processor in processors)
                    BindBlock(processor, distributionMode, isCombined);

                // два такта за один тик - для исключения простоев процессоров
                DoTick(executionMode, distributionMode, CurrentTick);

                CurrentTick++;
            }
            return this;
        }

        public void ResetStates()
        {
            ProcessorLeases.Clear();
            CurrentTick = 0;

            foreach (var block in Blocks)
                block.Reset();
            foreach (var process in Processes)
                process.Reset();
            foreach (var processor in Processors)
                processor.Reset();
        }


        // блок следующий блок привязывается в любом случае
        // блокировки на исполнение будут в DoTick методе
        private void BindBlock(KProcessor processor, EDistributeModeType distributionMode, bool isCombined)
        {
            KProcess? targetProcess = GetProcess(processor.Index, distributionMode, isCombined);

            if (targetProcess == null) return;

            KBlockBinding? nextBlock = targetProcess.NextBlock;

            if (nextBlock == null) return;

            // поскольку этот метод рассчитан на работу с блоками,
            // работу по валидации блоков для распределенного режима
            // выполняю тут
            if (distributionMode == EDistributeModeType.Distributed)
            {
                // TODO (wwaffe): чет сомнения в данной блокировке, рефактор
                // по факту реализация последовательного выполнения блока во всех процессах на одном процессоре
                if (processor.CurrentBlock != null && processor.CurrentBlock.Process.Index >= targetProcess.Index)
                {
                    uint currentThreadIndex = nextBlock.ThreadIndex;
                    int firstProcessIndexFotThread = Processes.Where(p => p.ThreadIndex == currentThreadIndex).Min(p => p.Index);

                    if (isCombined && targetProcess.Index != 0) return;

                    if (!isCombined && targetProcess.Index != firstProcessIndexFotThread)
                        return;
                }

                // запоминаем индекс текущего блока, дабы потом выбирать те же
                if (ProcessorLeases.ContainsKey(processor.Index))
                {
                    ProcessorLeases.Remove(processor.Index);
                    ProcessorLeases.Add(processor.Index, nextBlock.Block.PipelineIndex);
                }
                else
                    ProcessorLeases.Add(processor.Index, nextBlock.Block.PipelineIndex);
            }

            processor.BindBlock(nextBlock, isCombined);
        }

        private KProcess? GetProcess(int processorIndex, EDistributeModeType distributionMode, bool isCombined)
        {
            KProcess? currentProcess = null;
            IEnumerable<KProcess> processes = new HashSet<KProcess>();

            if (isCombined)
                processes = Processes.Where(p => p.Status != EProcessState.Done);
            else
            {
                var currentTasks = Blocks.SelectMany(b => b.Bindings).Where(bb => bb.Status != EBlockState.Done);
                if (currentTasks.Any())
                {
                    uint currentThread = currentTasks.Min(bb => bb.ThreadIndex);
                    processes = Processes.Where(p => p.Status != EProcessState.Done && p.BlockBindings.Any(bb => bb.ThreadIndex == currentThread));
                }
            }

            if (distributionMode == EDistributeModeType.Centralized)
            {
                if (ProcessorLeases.ContainsKey(processorIndex))
                {
                    var currentProcessIndex = ProcessorLeases[processorIndex];
                    currentProcess = processes.FirstOrDefault(p => p.Index == currentProcessIndex);

                    // чистим мусор в привязках
                    if (currentProcess == null)
                        ProcessorLeases.Remove(processorIndex);
                    else
                        return currentProcess;
                }

                currentProcess = processes.FirstOrDefault(p => !ProcessorLeases.ContainsValue(p.Index));

                if (currentProcess != null)
                    ProcessorLeases.Add(processorIndex, currentProcess.Index);
            }

            if (distributionMode == EDistributeModeType.Distributed)
            {
                var suggestedProcesses = processes.Where(p => p.Status != EProcessState.Busy && p.NextBlock != null);

                // отдавать предпочтение процессу, порядковый номер следующего блока у которого равен
                // порядковому номеру последнего исполненного блока этим процессором
                if (suggestedProcesses.Count() > 1 && ProcessorLeases.ContainsKey(processorIndex))
                    currentProcess = suggestedProcesses.FirstOrDefault(p => p.NextBlock!.Block.PipelineIndex == ProcessorLeases[processorIndex]);

                currentProcess ??= suggestedProcesses.FirstOrDefault();
            }

            return currentProcess;
        }


        private void DoTick(EExecuteModeType executionMode, EDistributeModeType distributionMode, int currentTick)
        {
            foreach (var processor in Processors.Where(p => p.Status == EProcessorState.Busy))
            {
                // блокировки первого синхронного
                if (executionMode == EExecuteModeType.SyncFirst)
                {
                    if (processor.CurrentBlock!.Process.Index == 3 && processor.CurrentBlock!.Block.PipelineIndex == 0 && currentTick == 13)
                    {

                    }
                    // проверка на возможность запуска блока (рекурсивно по процессу)
                    if (processor.CurrentBlock != null && !processor.CurrentBlock.CanStart(currentTick)) continue;
                }

                // блокировки второго синхронного
                if(executionMode == EExecuteModeType.SyncSecond)
                {
                    if (processor.CurrentBlock!.Process.Index == 0 && processor.CurrentBlock!.Block.PipelineIndex == 2 && currentTick == 3)
                    {

                    }
                    // проверка на возможность запуска блока (рекурсивно по привязкам)
                    if (processor.CurrentBlock != null && !processor.CurrentBlock.CanStartSS(currentTick)) continue;
                }

                // блокировка исполнения блока, если процесс не готов
                if (distributionMode == EDistributeModeType.Distributed)
                    if (processor.CurrentBlock!.Process.Status == EProcessState.Waiting)
                        if (!processor.CurrentBlock!.Process.CurrentTasks.Contains(processor.CurrentBlock!))
                            continue;

                // блокировка исполнения блока, если предыдущий блок не готов
                if (distributionMode == EDistributeModeType.Centralized)
                    if (processor.CurrentBlock != null && processor.CurrentBlock!.FromPreviousProcess != null)
                        if (processor.CurrentBlock!.FromPreviousProcess.IsBinded)
                            continue;

                processor.DoTick(currentTick);
            }
        }

    }
}