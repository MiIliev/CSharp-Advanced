int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int rows = 0; rows < n; rows++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    for (int cols = 0; cols < n; cols++)
    {
        matrix[rows, cols] = input[cols];
    }
}

int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += matrix[i, i];
}

Console.WriteLine(sum);