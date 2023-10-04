using System;

int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];
for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    matrix[row] = new int[data.Count()];
    for (int i = 0; i < data.Count(); i++)
    {
        matrix[row][i] = data[i];
    }
}

string input = null;
while ((input = Console.ReadLine()) != "END")
{
    string[] command = input.Split().ToArray();
    string action = command[0];
    int row = int.Parse(command[1]);
    int col = int.Parse(command[2]);
    int value = int.Parse(command[3]);

    if (row < 0 ||
        col < 0 ||
        row > matrix.Length-1 ||
        col > matrix[row].Length-1)
    {
        Console.WriteLine("Invalid coordinates");
    }
    else
    {
        switch (action)
        {
            case "Add":
                matrix[row][col] += value;
                break;
            case "Subtract":
                matrix[row][col] -= value;
                break;
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int numberIndex = 0; numberIndex < matrix[row].Length; numberIndex++)
    {
        Console.Write(matrix[row][numberIndex] + " ");
    }
    Console.WriteLine();
}