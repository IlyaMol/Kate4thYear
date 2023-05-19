using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessorExtensions
    {
        public static KProcessor BindBlock(this KProcessor processor, KBlockBinding block)
        {
            processor.CurrentBlock = block;
            block.CurrentExecutor = processor;
            return processor;
        }
    }

    public class KProcessor
    {
        public int Index { get; set; } = 0;
        public KBlockBinding? CurrentBlock { get; set; }

        public EProcessorState Status 
        { 
            get { return (CurrentBlock == null ? EProcessorState.Ready : EProcessorState.Busy); } 
        }

        public KProcessor(int index) { Index = index; }

        public void DoTick(int currentTick)
        {
            if (CurrentBlock == null) return;
            CurrentBlock.DoTick(currentTick);
        }

        public void Reset()
        {
            CurrentBlock = null;
        }
    }
}
