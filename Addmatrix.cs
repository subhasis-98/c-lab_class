
public class Addmatrix
{
    public void Add()
    {
        int[,] ara = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
        int[,] arb = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

        int row = ara.GetLength(0);
        int col = ara.GetLength(1);

        int row1 = arb.GetLength(0);
        int col1 = arb.GetLength(1);

        // Check if both matrices have the same dimensions
        if (row != row1 || col != col1)
        {
            Console.WriteLine("Matrices must have the same dimensions to be added.");
            return;
        }

        // Initialize the resultant matrix
        int[,] add = new int[row, col];

        // Perform matrix addition
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                add[i, j] = ara[i, j] + arb[i, j];
            }
        }

        // Display the resultant matrix
        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(add[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
