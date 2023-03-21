namespace ProblemTwo
{
    public class Calculations
    {
        /// <summary>
        /// Равномерное структурирование
        /// </summary>
        /// <param name="sourceStruct"></param>
        /// <returns></returns>
        //presentation 4, s3.1 o3.1(4)
        public float[] GetUniformSruct(int[] sourceStruct)
        {
            float[] reultStruct = new float[sourceStruct.Length];
            int sumTime = sourceStruct.Sum(x => x);
            for(int elementIndex = 0; elementIndex < reultStruct.Length; elementIndex++)
            {
                reultStruct[elementIndex] = sumTime / sourceStruct.Length;
            }
            return reultStruct;
        }

        /// <summary>
        /// Оценка величины накладных расходов
        /// </summary>
        /// <param name="sourceStruct"></param>
        /// <param name="processCount"></param>
        /// <returns></returns>
        public float OverheadCosts(int[] sourceStruct, int processCount = 0)
        {
            int sumTime = sourceStruct.Sum(x => x);
            Func<int, int> dd = x => 
            {
                return (processCount - 1) * sumTime * (x - 1) / (x * (x + processCount - 1));
            };

            float m = MathF.Sqrt(processCount);
            float estimate = MathF.Max(1 + MathF.Floor(m), 2 + MathF.Floor(m));

            return estimate;
        }

        /// <summary>
        /// Оптимальное число блоков
        /// </summary>
        /// <param name="sourceStruct"></param>
        /// <param name="processorCount"></param>
        /// <param name="processCount"></param>
        /// <param name="tau"></param>
        /// <returns></returns>
        public float OptimalBlockCount(int[] sourceStruct, int processorCount, int processCount, float? tau = null)
        {
            int sumTime = sourceStruct.Sum(x => x);

            if (tau == null) tau = 1;

            Func<float, float> delta = x =>
            {
                return (processCount - 1) * sumTime * (1 - 1 / x) - (x + processCount - 1) * (float)tau;
            };

            float x1 = MathF.Floor(MathF.Sqrt((processCount - 1) * sumTime / (float)tau));
            float x2 = MathF.Floor(MathF.Sqrt((processCount - 1) * sumTime / (float)tau)) + 1;

            float max = 0;
            float s1 = 0;
            for (var i = MathF.Min(x1, 2); i <= MathF.Min(x2, processorCount); i++)
            {
                var d = delta(i);

                if (d > max)
                {
                    max = d;
                    s1 = i;
                }
            }

            return s1;
        }
    }
}
