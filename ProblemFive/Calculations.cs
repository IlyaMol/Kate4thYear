namespace ProblemFive
{
    public class Calculations
    {
        public int GetKArgument(int processorCount, int blockCount)
        {
            return blockCount / processorCount;
        }

        public double GetRArgument(int processorCount, int blockCount)
        {
            double number = (double)blockCount / (double)processorCount;

            double k = (int)number;
            return Math.Round(blockCount - (k * processorCount), 2);
        }

        public int GetProcessRequiredCount(int minExecTime, int processorCount, int blockCount, double eVal)
        {
            double k = GetKArgument(processorCount, blockCount);
            double r = GetRArgument(processorCount, blockCount);

            if (r <= 0)
            {
                var n = (int)Math.Floor(Math.Sqrt((processorCount - 1) * minExecTime / k * eVal));
                if (n > 0) return n;
                return n + 1;
            }
            else
            {
                var n = (int)Math.Floor(Math.Sqrt((r - 1) * minExecTime / ((k + 1) * eVal)));
                if (n > 0) return n;
                return n + 1;
            }
        }
    }
}