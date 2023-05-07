namespace SolverForms.Helpers
{
    public static class ArrayExtensions
    {
        public static int[] ToOneDimArray(this int[,]array) 
        { 
            int[] oneDimArray =  new int[array.Length];
            int valIndex = 0;
            for(int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
                for(int columnIndex = 0; columnIndex < array.GetLength(1); columnIndex++)
                {
                    oneDimArray[valIndex] = array[rowIndex, columnIndex];
                    valIndex++;
                }
            return oneDimArray;
        }
        public static int[,] ToTwoDimArray(this int[] array, int columnCount)
        {
            int[,] twoDimArray = new int[array.Length/columnCount, columnCount];
            int valIndex = 0;
            for (int rowIndex = 0; rowIndex < twoDimArray.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < twoDimArray.GetLength(1); columnIndex++)
                {
                    twoDimArray[rowIndex, columnIndex] = array[valIndex];
                    valIndex++;
                }

            return twoDimArray;
        }
    }
}
