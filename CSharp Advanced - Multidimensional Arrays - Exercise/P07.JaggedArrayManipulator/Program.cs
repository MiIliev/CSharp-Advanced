int[][] matrix = CreateMatrix();
AnalyzeMatrix(matrix);

string input = null;
while ((input = Console.ReadLine()) != "End")
{
    string[] inputArr = input.Split().ToArray();

    if (inputArr.Length != 4)
    {
        continue;
    }

    string command = inputArr[0];
    int row = int.Parse(inputArr[1]);
    int col = int.Parse(inputArr[2]);
    int value = int.Parse(inputArr[3]);

    if (row > matrix.GetLength(0) - 1 ||
        row < 0 ||
        col > matrix[row].Length -1 ||
        col < 0)
    { 
        continue;
    }

    if (command == "Add")
    {
        matrix[row][col] += value;
    }
    else if (command == "Subtract")
    {
        matrix[row][col] -= value;
    }
}

PrintMatrix(matrix);



static int[][] CreateMatrix()
{
    int rowsCount = int.Parse(Console.ReadLine());
    int[][] matrix = new int[rowsCount][];
    for (int row = 0; row < rowsCount; row++)
    {
        int[] data = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        matrix[row] = data;
    }
    return matrix;
}

static void AnalyzeMatrix(int[][] matrix)
{
    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
    {
        if (matrix[row].Length == matrix[row + 1].Length)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] = matrix[row][col] * 2;
                matrix[row + 1][col] = matrix[row + 1][col] * 2;
            }
        }
        else
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                matrix[row][col] = matrix[row][col] / 2;
            }
            for (int col = 0; col < matrix[row + 1].Length; col++)
            {
                matrix[row + 1][col] = matrix[row + 1][col] / 2;
            }

        }
    }
}

static void PrintMatrix(int[][] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix[row].Length; column++)
        {
            Console.Write($"{matrix[row][column]} ");
        }
        Console.WriteLine();
    }
}

