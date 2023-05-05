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

            return processor;
        }
    }

    public class KProcessor
    {
        public ProcessorState Status
        {
            get
            {
                if(CurrentProcess == null)
                    return ProcessorState.Idle;
                else if(CurrentProcess.NextTask == null)
                {
                    CurrentProcess.Executor = null;
                    return ProcessorState.Idle;
                }
                else
                {
                    if(CurrentProcess.NextTask.Status == BlockState.Busy) return ProcessorState.Ready;
                    else return ProcessorState.Ready;
                }
            }
        }

        public KProcess? CurrentProcess { get; set; }

        public void Execute(int startStamp)
        {
            if (Status == ProcessorState.Idle) return;

            KBlockBinging? nextBlockBinding = CurrentProcess!.NextTask;

            if (nextBlockBinding == null) return;

            nextBlockBinding.DoTick(startStamp);
        }
    }
}
