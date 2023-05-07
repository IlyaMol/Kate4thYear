using ProblemOne.KStates;
using System.Diagnostics;

namespace ProblemOne
{
    public static class KStateMachineExtensions
    {
        public static KStateMachine AddProcessors(this KStateMachine machine, int procCount)
        {
            for (int iteration = 0; iteration < procCount; iteration++)
                machine.Processors.Add(new KProcessor(machine) { Index = iteration });
            return machine;
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
            int tickCount = 0;
            ResetStates();
            // одна итерация цикла - один такт машины
            while (Processes.Any(p => p.Status != ProcessState.Done))
            {
                // TODO(wwaffe): выполняем две операции за такт, дабы не дать процессорам простаивать
                for(int iterations = 0; iterations < 2; iterations++)
                {
                    // назначаем свободным процессорам незанятые процессы по порядку
                    BindProcesses(combined);

                    // либо превому освободившемуся процессору, первый доступный процесс
                    // пробуем исполнить свободные блоки в ожидающих процессах
                    ExecuteProcessors(tickCount, procType);
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
        }

        private void BindProcesses(bool isCombined)
        {
            // в зависимости от необходимости совмещения
            if(isCombined)
                foreach (KProcessor processor in Processors.Where(p => p.Status == ProcessorState.Idle).ToList())
                    processor.BindProcess(Processes.FirstOrDefault(p => p.Status == ProcessState.Ready));
            else
                if(Processors.All(p => p.Status == ProcessorState.Idle))
                    foreach (KProcessor processor in Processors.Where(p => p.Status == ProcessorState.Idle).ToList())
                        processor.BindProcess(Processes.FirstOrDefault(p => p.Status == ProcessState.Ready));
        }

        private void ExecuteProcessors(int tickCount, EProcType executionType)
        {
            foreach (var processor in Processors)
                processor.Execute(tickCount, executionType);
        }
    }
}