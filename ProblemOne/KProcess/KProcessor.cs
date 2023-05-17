using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessorExtensions
    {
        public static KProcessor BindProcess(this KProcessor processor, in KProcess? bindingProcess)
        {
            if(bindingProcess == null) return processor;

            if(processor.CurrentProcess != null)
            {
                processor.CurrentProcess.Executor = null;
                bindingProcess.TransitiveBlock = processor.CurrentProcess.LastBlock;
            }
            processor.CurrentProcess = bindingProcess;
            bindingProcess.Executor = processor;
            bindingProcess.ExecutorIndex = processor.Index;

            return processor;
        }
    }

    public class KProcessor
    {
        public int Index { get; set; } = 0;

        private KProcess? _currentProcess;
        public KProcess? CurrentProcess 
        { 
            get { return _currentProcess; }
            set
            {
                _currentProcess = value;
            }
        }

        public KStateMachine ParentMachine { get; set; }

        public ProcessorState Status
        {
            get
            {
                if (CurrentProcess == null) return ProcessorState.Idle;
                if (CurrentProcess != null && (CurrentProcess.Status == ProcessState.Done 
                    || CurrentProcess.Status == ProcessState.Ready)) return ProcessorState.Idle;
                else if (CurrentProcess != null && CurrentProcess.Status == ProcessState.Busy) return ProcessorState.Busy;
                else return ProcessorState.Ready;
            }
        }

        public KProcessor(KStateMachine parentMachine)
        {
            ParentMachine = parentMachine;
        }

        public int Execute(int startStamp, EProcType syncType, bool isCombined)
        {
            if (Status == ProcessorState.Idle) return startStamp;

            KBlockBinding? nextBlockBinding = CurrentProcess!.CurrentTask;

            if (nextBlockBinding == null)
                nextBlockBinding = CurrentProcess!.NextTask;

            if (nextBlockBinding != null)
            {
                startStamp = nextBlockBinding.DoTick(startStamp, syncType, isCombined);

                // если после предыдущего шага процессор готов - сразу же выполняем следующий блок
                if (nextBlockBinding.Status == BlockState.Done && Status == ProcessorState.Ready)
                    startStamp = Execute(startStamp, syncType, isCombined);
            }

            return startStamp;
        }
    }
}
