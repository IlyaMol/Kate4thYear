﻿namespace ProblemTwo
{
    public class Calculations
    {
        /// <summary>
        /// Равномерное структурирование
        /// </summary>
        public double[] GetUniformSruct(double[] sourceStruct)
        {
            double[] resultStruct = new double[sourceStruct.Length];
            double sumTime = sourceStruct.Sum(x => x);
            for(int elementIndex = 0; elementIndex < resultStruct.Length; elementIndex++)
            {
                resultStruct[elementIndex] = sumTime / sourceStruct.Length;
            }
            
            return resultStruct;
        }

        /// <summary>
        /// Оценка величины накладных расходов
        /// </summary>
        public double OverheadCosts(double[] sourceStruct, int processCount = 0)
        {
            double sumTime = sourceStruct.Sum(x => x);
            Func<double, double> dd = x => 
            {
                return (processCount - 1) * sumTime * (x - 1) / (x * (x + processCount - 1));
            };

            double m = MathF.Sqrt(processCount);
            double estimate = Math.Max(dd(1 + Math.Floor(m)), dd(2 + Math.Floor(m)));

            return estimate;
        }

        public double GetSqrtProcess(int processCount = 0)
        {
            return MathF.Sqrt(processCount);
        }
        public int GetSumTBlocks(double[] sourceStruct)
        {
            return (int)sourceStruct.Sum(x => x);
        }
        /// <summary>
        /// Оптимальное число блоков
        /// </summary>
        public double OptimalBlockCount(double[] sourceStruct, int processorCount, int processCount, double? tau = null)
        {
            double sumTime = sourceStruct.Sum(x => x);

            if (tau == null) tau = 1;

            Func<double, double> delta = x =>
            {
                return (processCount - 1) * sumTime * (1 - 1 / x) - (x + processCount - 1) * (double)tau;
            };

            double x1 = Math.Floor(Math.Sqrt((processCount - 1) * sumTime / (double)tau));
            double x2 = Math.Floor(Math.Sqrt((processCount - 1) * sumTime / (double)tau)) + 1;

            double max = 0;
            double s1 = 0;
            for (var i = Math.Min(x1, 2); i <= Math.Min(x2, processorCount); i++)
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

        /// <summary>
        /// Оптимальное число процессоров
        /// </summary>
        public uint OptimalProcessorCount(double[] sourceStruct, int processCount)
        {
            return (uint)Math.Min(processCount, Math.Ceiling(sourceStruct.Sum() / sourceStruct.Max()));
        }
    }
}