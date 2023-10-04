int[] size = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();
int rows = size[0];
int cols = size[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

int sum = 0;

for (int col = 0; col < cols; col++)
{
	for (int row = 0; row < rows; row++)
	{
        sum += matrix[row, col];
	}
    Console.WriteLine(sum);
    sum = 0;
}