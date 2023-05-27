namespace SolverForms.Extensions
{
    public static class ArrayExtensions
    {
        public static int[] ToOneDimArray(this int[,] array)
        {
            int[] oneDimArray = new int[array.Length];
            int valIndex = 0;
            for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < array.GetLength(1); columnIndex++)
                {
                    oneDimArray[valIndex] = array[rowIndex, columnIndex];
                    valIndex++;
                }
            return oneDimArray;
        }
        public static int[,] ToTwoDimArray(this int[] array, int columnCount)
        {
            int[,] twoDimArray = new int[array.Length / columnCount, columnCount];
            int valIndex = 0;
            for (int rowIndex = 0; rowIndex < twoDimArray.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < twoDimArray.GetLength(1); columnIndex++)
                {
                    twoDimArray[rowIndex, columnIndex] = array[valIndex];
                    valIndex++;
                }

            return twoDimArray;
        }

        public static bool Compare(this int[,] array1, int[,] array2)
        {
            if (array1.GetLength(0) != array2.GetLength(0) || array1.GetLength(1) != array2.GetLength(1))
                return false;

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (array1[i, j] != array2[i, j])
                        return false;
                }
            }

            return true;
        }
    }
}
