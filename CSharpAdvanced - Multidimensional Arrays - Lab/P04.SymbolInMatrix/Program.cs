int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];

for (int rows = 0; rows < size; rows++)
{
    string data = Console.ReadLine();
    for (int cols = 0; cols < size; cols++)
    {
        matrix[rows, cols] = data[cols];
    }
}

char symbol = char.Parse(Console.ReadLine());
bool matchFound = false;
int matchRow = int.MinValue;
int matchCol = int.MinValue;

for (int rows = 0; rows < size; rows++)
{
    if (matchFound)
    {
        break;
    }
    for (int cols = 0; cols < size; cols++)
    {
        char match = matrix[rows, cols];
        if (match == symbol)
        {
            matchFound = true;
            matchRow = rows;
            matchCol = cols;
            break;
        }
    }
}

if (matchFound)
{
    Console.WriteLine($"({matchRow}, {matchCol})");
}
else
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}
