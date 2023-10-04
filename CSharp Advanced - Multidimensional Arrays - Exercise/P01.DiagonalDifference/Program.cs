int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size,size];

for (int row = 0; row < size; row++)
{
    int[] data = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    for (int column = 0; column < size; column++)
    {
        matrix[row,column] = data[column];
    }
}


int sumPrimaryDiagonal = 0;
int sumSecondaryDiagonal = 0;

for (int i = 0; i < size; i++)
{
    sumPrimaryDiagonal += matrix[i, i];
}

for (int i = 1;i <= size; i++)
{
    sumSecondaryDiagonal += matrix[i-1, matrix.GetLength(1) - i];
}

int result = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
Console.WriteLine(result);