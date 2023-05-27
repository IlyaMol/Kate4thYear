namespace ProblemOne
{
    public class KMatrixTransform
    {
        /// <summary>
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="subRowCount"></param>
        /// <returns>
        /// An array of submatrices of block processing times
        /// by the set number of processors (subRowCount)
        /// </returns>
        public static ICollection<int[,]> SplitMatrix(int[,] matrix, int subRowCount)
        {
            ICollection<int[,]> resultSubmatrixArray = new HashSet<int[,]>();

            int subMatrixCount = (int)Math.Ceiling(matrix.GetLength(0) / (double)subRowCount);

            for (int instanceIndex = 0; instanceIndex < subMatrixCount; instanceIndex++)
            {
                int[,] subMatrixInstance = new int[subRowCount, matrix.GetLength(1)];
                int len = matrix.Length;
                long kk = matrix.Length - subMatrixInstance.Length * instanceIndex;
                if(kk < subMatrixInstance.Length)
                    Array.Copy(matrix, subMatrixInstance.Length * instanceIndex, subMatrixInstance, 0, kk);
                else 
                    Array.Copy(matrix, subMatrixInstance.Length * instanceIndex, subMatrixInstance, 0, subMatrixInstance.Length);
                resultSubmatrixArray.Add(subMatrixInstance);
            }

            return resultSubmatrixArray;
        }

        // returns the matrix of block processing time
        // by the set number of processors
        public static int[,] BuildProcTimeMatrix(ICollection<int[,]> subMatricies)
        {
            if (subMatricies.Count < 1) return new int[0, 0];
            int subMatrixRow = subMatricies.First().GetLength(0);
            int subMatrixColumn = subMatricies.First().GetLength(1);
            int matrixRowCount = subMatrixRow * subMatricies.Count;
            int matrixColumnCount = subMatrixColumn * subMatricies.Count;
            int[,] resultMatrix = new int[matrixRowCount, matrixColumnCount];

            int subMatrixIndex = 0;
            int subMatrixCurrentRow = 0;
            int subMatrixCurrentColumn = 0;
            for(int rowIndex = 0; rowIndex < matrixRowCount; rowIndex++)
            {
                if(subMatrixCurrentRow >= subMatrixRow) 
                { 
                    subMatrixCurrentRow = 0;
                    int[,] subMatrixToDelete = subMatricies.First();
                    subMatricies.Remove(subMatrixToDelete);
                }
                for (int columnIndex = 0; columnIndex < matrixColumnCount; columnIndex++)
                {
                    if(subMatrixCurrentColumn >= subMatrixColumn) { subMatrixCurrentColumn = 0; subMatrixIndex++; }

                    if (subMatrixIndex < subMatricies.Count)
                        resultMatrix[rowIndex, columnIndex] = subMatricies.ElementAt(subMatrixIndex)[subMatrixCurrentRow, subMatrixCurrentColumn];
                    else
                        break;

                    subMatrixCurrentColumn++;
                }
                subMatrixIndex = 0;
                subMatrixCurrentColumn = 0;
                subMatrixCurrentRow++;
            }
            return resultMatrix;
        }
    }
}