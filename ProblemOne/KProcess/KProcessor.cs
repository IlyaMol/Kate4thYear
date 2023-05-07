using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessorExtensions
    {
        public static KProcessor BindProcess(this KProcessor processor, in KProcess? bindingProcess)
        {
            if(bindingProcess== null) return processor;

            processor.CurrentProcess = bindingProcess;
            bindingProcess.Executor = processor;
            bindingProcess.ExecutorIndex = processor.Index;

            return processor;
        }
    }

    public class KProcessor
    {
        public int Index { get; set; } = 0;
        public KProcess? CurrentProcess { get; set; }

        public KStateMachine ParentMachine { get; set; }

        public ProcessorState Status
        {
            get
            {
                if(CurrentProcess == null)
                    return ProcessorState.Idle;
                else if(CurrentProcess.Status == ProcessState.Done)
                {
                    CurrentProcess.Executor = null;
                    CurrentProcess = null;
                    return ProcessorState.Idle;
                }
                else
                {
                    if(CurrentProcess.Status == ProcessState.Busy) return ProcessorState.Busy;
                    else return ProcessorState.Ready;
                }
            }
        }

        public KProcessor(KStateMachine parentMachine)
        {
            ParentMachine= parentMachine;
        }

        public void Execute(int startStamp, EProcType syncType)
        {
            if (Status == ProcessorState.Idle) return;

            KBlockBinding? nextBlockBinding = CurrentProcess!.CurrentTask;

            if (nextBlockBinding == null)
                nextBlockBinding = CurrentProcess!.NextTask;

            if (nextBlockBinding != null)
            {
                nextBlockBinding.DoTick(startStamp, syncType);

                // если после предыдущего шага процессор готов - сразу же выполняем следующий блок
                if (nextBlockBinding.Status == BlockState.Done && Status == ProcessorState.Ready)
                    Execute(startStamp, syncType);
            }
        }
    }
}
