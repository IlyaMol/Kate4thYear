using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessorExtensions
    {
        public static KProcessor BindBlock(this KProcessor processor, KBlockBinding block)
        {
            processor.CurrentBlock = block;
            block.Block.LastExecutorIndex = processor.Index;
            block.ExecutorIndex = processor.Index;
            block.IsBinded = true;
            return processor;
        }
    }

    public class KProcessor
    {
        public int Index { get; set; } = 0;
        public KBlockBinding? CurrentBlock { get; set; }

        public EProcessorState Status 
        { 
            get 
            {
                if (CurrentBlock == null) return EProcessorState.Ready;
                if (CurrentBlock != null && CurrentBlock.Status == EBlockState.Done) return EProcessorState.Ready;
                return EProcessorState.Busy;
            } 
        }

        public KProcessor(int index) { Index = index; }

        public void DoTick(int currentTick)
        {
            if (CurrentBlock == null) return;
            if (CurrentBlock.Status == EBlockState.Binded)
                CurrentBlock.CurrentExecutor = this;
            CurrentBlock.DoTick(currentTick);
        }

        public void Reset()
        {
            CurrentBlock = null;
        }
    }
}
