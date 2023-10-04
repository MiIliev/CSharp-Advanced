int[] size = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string[,] matrix = CreateMatrix(size);

string input = null;

while ((input = Console.ReadLine()) != "END")
{
    string[] command = input.Split().ToArray();

    if (command.Length == 5 &&
        command[0] == "swap" &&
        int.Parse(command[1]) < matrix.GetLength(0) &&
        int.Parse(command[2]) < matrix.GetLength(1) &&
        int.Parse(command[3]) < matrix.GetLength(0) &&
        int.Parse(command[4]) < matrix.GetLength(1))

    {
        int row1 = int.Parse(command[1]);
        int col1 = int.Parse(command[2]);
        int row2 = int.Parse(command[3]);
        int col2 = int.Parse(command[4]);
        string cache = matrix[row1, col1];

        matrix[row1, col1] = matrix[row2, col2];
        matrix[row2, col2] = cache;
        PrintMatrix(matrix);
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

}

static string[,] CreateMatrix(int[] size)
{
    int rowsCount = size[0];
    int colsCount = size[1];
    string[,] matrix = new string[rowsCount, colsCount];

    for (int row = 0; row < rowsCount; row++)
    {
        string[] data = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        for (int col = 0; col < colsCount; col++)
        {
            matrix[row, col] = data[col];
        }
    }
    return matrix;
}

static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]} ");
        }
        Console.WriteLine();
    }
}