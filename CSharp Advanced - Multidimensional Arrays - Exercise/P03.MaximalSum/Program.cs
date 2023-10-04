int[] size = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[,] matrix = CreateMatrix(size);
int[] searchedSquarePos = new int[9];

Console.WriteLine($"Sum = {FindMaxSum(matrix, searchedSquarePos)}");
Console.WriteLine(
    $"{searchedSquarePos[0]} {searchedSquarePos[1]} {searchedSquarePos[2]}\n" +
    $"{searchedSquarePos[3]} {searchedSquarePos[4]} {searchedSquarePos[5]}\n" +
    $"{searchedSquarePos[6]} {searchedSquarePos[7]} {searchedSquarePos[8]}");



static int[,] CreateMatrix(int[] size)
{
    int rowsCount = size[0];
    int colsCount = size[1];
    int[,] matrix = new int[rowsCount, colsCount];

    for (int row = 0; row < rowsCount; row++)
    {
        int[] data = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries) // Judge does not give full score without removing the empty entries.
            .Select(int.Parse)
            .ToArray();
        for (int col = 0; col < colsCount; col++)
        {
            matrix[row, col] = data[col];
        }
    }
    return matrix;
}

static int FindMaxSum(int[,] matrix, int[] searchedSquarePos)
{
    int maxSum = 0;
    for (int row = 0; row < matrix.GetLength(0) - 2; row++)
    {
        for (int col = 0; col < matrix.GetLength(1) - 2; col++) 
        {
            int sum = 0;
            sum +=
                matrix[row, col] +
                matrix[row, col + 1] +
                matrix[row, col + 2] +

                matrix[row + 1, col] +
                matrix[row + 1, col + 1] +
                matrix[row + 1, col + 2] +

                matrix[row + 2, col] +
                matrix[row + 2, col + 1] +
                matrix[row + 2, col + 2];

            if (sum > maxSum)
            {
                maxSum = sum;

                searchedSquarePos[0] = matrix[row, col];
                searchedSquarePos[1] = matrix[row, col+1];
                searchedSquarePos[2] = matrix[row, col+2];

                searchedSquarePos[3] = matrix[row+1, col];
                searchedSquarePos[4] = matrix[row+1, col+1];
                searchedSquarePos[5] = matrix[row+1, col+2];

                searchedSquarePos[6] = matrix[row+2, col];
                searchedSquarePos[7] = matrix[row+2, col+1];
                searchedSquarePos[8] = matrix[row+2, col+2];
            }
        }
    }
    return maxSum;
}