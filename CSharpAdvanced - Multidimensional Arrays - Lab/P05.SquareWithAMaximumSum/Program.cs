int[] size = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();
int rowsCount = size[0];
int colsCount = size[1];
int[,] matrix = new int[rowsCount, colsCount];

for (int row = 0; row < rowsCount; row++)
{
    int[] data = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < colsCount; col++)
    {
        matrix[row, col] = data[col];
    }
}

int maxSum = int.MinValue;
int indexRow = int.MinValue;
int indexCol = int.MinValue;

for (int row = 0; row < rowsCount-1; row++)
{
    for (int col = 0; col < colsCount-1; col++)
    {
        int sum = matrix[row, col]
            + matrix[row, col + 1]
            + matrix[row + 1, col]
            + matrix[row + 1, col + 1];
        if (sum > maxSum)
        {
            indexRow = row;
            indexCol = col;
            maxSum = sum;
        }
    }
}

Console.WriteLine($"" +
    $"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol+1]}\n" +
    $"{matrix[indexRow+1, indexCol]} {matrix[indexRow+1, indexCol+1]}\n" +
    $"{maxSum}");