long size = int.Parse(Console.ReadLine());
long[][] triangle = new long[size][];
triangle[0] = new long[1] { 1 };

for (int row = 1; row < size; row++)
{
	triangle[row] = new long[row+1];
	for (int col = 0; col < row+1; col++)
	{
		if (col < triangle[row - 1].Length)
		{
            triangle[row][col] += triangle[row - 1][col];
        }
        if (col > 0)
		{
            triangle[row][col] += triangle[row - 1][col - 1];
        }
    }
}

for (int row = 0; row < triangle.Length; row++)
{
    for (int col = 0; col < triangle[row].Length; col++)
    {
        Console.Write($"{triangle[row][col]} ");
    }
    Console.WriteLine();
}