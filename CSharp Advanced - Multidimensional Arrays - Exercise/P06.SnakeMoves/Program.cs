int[] size = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

char[] snake = Console.ReadLine()
    .ToCharArray();

int snakePosition = 0;

char[,] matrix = new char[size[0], size[1]];

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    if (rows % 2 == 0)
    {
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            if (snakePosition > snake.Length-1)
            {
                snakePosition = 0;
            }
            matrix[rows, cols] = snake[snakePosition++];
        }
    }
    else
    {
        for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--)
        {
            if (snakePosition > snake.Length-1)
            {
                snakePosition = 0;
            }
            matrix[rows, cols] = snake[snakePosition++];
        }
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write($"{matrix[row, column]}");
    }
    Console.WriteLine();
}