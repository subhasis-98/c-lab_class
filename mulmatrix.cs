
public class Mulmatrix
{
    public void Mul()
    {
        // Define two 3x3 matrices
        int[,] matrixA = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
        int[,] matrixB = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
        int row = matrixA.GetLength(0);
        int col = matrixA.GetLength(1);

        int row1 = matrixB.GetLength(0);
        int col1 = matrixB.GetLength(1);

        // Initialize the resultant 3x3 matrix
        int[,] resultMatrix = new int[3, 3];

        if (row != col1 || col != row1)
        {
            Console.WriteLine("Matrices must have the same dimensions to be added.");
            return;
        }

        // Perform matrix multiplication
        for (int i = 0; i < 3; i++) // Iterate over rows of matrixA
        {
            for (int j = 0; j < 3; j++) // Iterate over columns of matrixB
            {
                resultMatrix[i, j] = 0; // Initialize element
                
                for (int k = 0; k < 3; k++) // Iterate over elements to sum products
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