// 2x2 changes to a user defined rectangle

Console.WriteLine("Define the size of the matrix:");
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

Console.WriteLine("Define the size of the rectangle that will be summed:");
int[] rectangleSize = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();
int rowsRectangle = rectangleSize[0];
int colsRectangle = rectangleSize[1];


int maxSum = int.MinValue;
int indexRow = int.MinValue;
int indexCol = int.MinValue;

for (int row = 0; row <= rowsCount-rowsRectangle; row++)
{
    for (int col = 0; col <= colsCount-colsRectangle; col++)
    {
        int sum = 0;
        for (int searchedRow = 0; searchedRow < rowsRectangle; searchedRow++)
        {
            for (int searchedCol = 0; searchedCol < colsRectangle; searchedCol++)
            {
                sum += matrix[row+searchedRow, col + searchedCol];
            }
        }
        if (sum > maxSum)
        {
            maxSum = sum;
            indexRow = row;
            indexCol = col;
        }
    }
}

for (int row = 0; row < rowsRectangle; row++)
{
    for (int col = 0; col < colsRectangle; col++)
    {
        Console.Write($"{matrix[indexRow + row, indexCol + col]} ");
    }
    Console.WriteLine();
}
Console.WriteLine(maxSum);
