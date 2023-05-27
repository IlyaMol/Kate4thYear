using ProblemOne.KStates;

namespace ProblemOne
{
    public static class KProcessorExtensions
    {
        public static KProcessor BindBlock(this KProcessor processor, KBlockBinding block , bool isCombined)
        {
            // при смене потока блоков - назначаем текущий блок переходным
            // нужно для корректного совмещения (у следующего процесса - предыдущий блок
            // это последний блок предыдущего процесса. 
            if (processor.CurrentBlock != null && isCombined)
                if (processor.CurrentBlock.ThreadIndex < block.ThreadIndex)
                    block.Process.TransitiveBlock = processor.CurrentBlock;

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

        public int ExecutedBlockCount { get; set; }

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
            {
                ExecutedBlockCount++;
                CurrentBlock.CurrentExecutor = this;
            }
            CurrentBlock.DoTick(currentTick);
        }

        public void Reset()
        {
            ExecutedBlockCount = 0;
            CurrentBlock = null;
        }
    }
}
