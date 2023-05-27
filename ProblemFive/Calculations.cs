namespace ProblemFive
{
    public class Calculations
    {
        public int GetProcessRequiredCount(int minExecTime, int processorCount, int blockCount, double eVal)
        {
            double number = blockCount / processorCount;

            int k = (int)number;
            int r = (int)(Math.Round(number - k, 2) * 100);

            if (r > 0)
                return (int)Math.Ceiling(Math.Sqrt((r - 1) * minExecTime / (k+1) * eVal));

            return (int)Math.Ceiling(Math.Sqrt((processorCount - 1) * minExecTime / k * eVal)); ;
        }
    }
}