namespace Task2_1
{
    public static class DiagonalMatrixHelper
    {
        public static DiagonalMatrix Add(this DiagonalMatrix firstMatrix, DiagonalMatrix secondMatrix)
        {
            firstMatrix ??= new DiagonalMatrix();
            secondMatrix ??= new DiagonalMatrix();
            int newMatrixSize;
            if (firstMatrix.Size > secondMatrix.Size)
            {
                newMatrixSize = firstMatrix.Size;
            }
            else
            {
                newMatrixSize = secondMatrix.Size;
            }
            int[] elements = new int[newMatrixSize];
            
            for (int i= 0; i < newMatrixSize; i++)
            {
                elements[i] = firstMatrix[i, i] + secondMatrix[i, i];
            }
            return new DiagonalMatrix(elements);
        }
    }
}
