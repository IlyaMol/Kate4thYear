namespace ProblemOne
{
    public enum EProcStatus
    {
        Idle,   // процессору не назначен процесс
        Ready,  // процессор выполнил блок и ждет возможности выполнить следующий
        Busy    // процессор выполняет блок
    }

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
        public EProcStatus Status
        {
            get
            {
                if(CurrentProcess == null)
                    return EProcStatus.Idle;
                else if(CurrentProcess.NextBlock == null)
                {
                    CurrentProcess.Executor = null;
                    return EProcStatus.Idle;
                }
                else
                {
                    if(CurrentProcess.NextBlock.Status == EStatus.Busy) return EProcStatus.Busy;
                    else return EProcStatus.Ready;
                }
            }
        }

        public KProcess? CurrentProcess { get; set; }

        public void ExecuteNext(int startStamp)
        {
            if (Status == EProcStatus.Idle) return;

            KBlockBinging? nextBlockBinding = CurrentProcess!.NextBlock;

            if (Status == EProcStatus.Busy)
            {
                if (startStamp >= nextBlockBinding!.BlockEndTime)
                {
                    nextBlockBinding.Status = EStatus.Done;
                }
                else return;
            }


            if (nextBlockBinding == null) return;

            CurrentProcess.LastExecutedBlockIndex = nextBlockBinding.ExecuteBlock(startStamp);
        }
    }
}
