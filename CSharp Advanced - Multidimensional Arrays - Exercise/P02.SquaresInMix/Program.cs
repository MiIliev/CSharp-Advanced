int[] size = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];
int count = 0;

for (int row = 0; row < rows; row++)
{
    string[] data = Console.ReadLine()
        .Split()
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = char.Parse(data[col]);
    }
}

for (int row = 0; row < rows-1; row++)
{
    char firstChar;
    char secondChar;
    char thirdChar;
    char fourthChar;
    for (int col = 0; col < cols-1; col++)
    {
        firstChar = matrix[row, col];
        secondChar = matrix[row, col + 1];
        thirdChar = matrix[row + 1, col];
        fourthChar = matrix[row + 1, col + 1];
        if (firstChar == secondChar && secondChar == thirdChar && thirdChar == fourthChar)
        {
            count++;
        }
    }
}

Console.WriteLine(count);