public class Mulmatrix23
{
    public void Mulll()
    {
        // Define a 3x2 matrix (Matrix A)
        int[,] matrixA = {
            { 1, 2 },
            { 1, 2 },
            { 1, 2 }
        };

        // Define a 2x3 matrix (Matrix B)
        int[,] matrixB = {
            { 1, 2, 3 },
            { 1, 2, 3 }
        };

        // Initialize the resultant 3x3 matrix
        int[,] resultMatrix = new int[3, 3];

        // Perform matrix multiplication
        for (int i = 0; i < 3; i++) // Rows of A
        {
            for (int j = 0; j < 3; j++) // Columns of B
            {
                resultMatrix[i, j] = 0; // Initialize element
                for (int k = 0; k < 2; k++) // Common dimension (columns of A, rows of B)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        // Display the resultant matrix
        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
