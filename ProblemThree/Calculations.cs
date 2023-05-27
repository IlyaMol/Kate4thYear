namespace ProblemThree
{
    public class Calculations
    {
        // минимальное время выполнения
        public int MinimumCompletionTime(double[] sourceQueue, int processorCount, 
                                         int processCount, int copyCount)
        {
            return processCount / Math.Min(processorCount, copyCount) * (int)sourceQueue.Sum();
        }

        public int RequiredProcessorCount(int processorCount, int copyCount)
        {
            return Math.Min(copyCount, processorCount);
        }

        public int MinimumProcessorCount(int processorCount, int processCount, int copyCount)
        {
            return processCount / Math.Min(copyCount, processorCount);
        }
    }
}