using System.Numerics;
using System.Runtime.CompilerServices;

int size = int.Parse(Console.ReadLine());
char[,] sea = new char[size, size];
int shipRow = 0;
int shipCol = 0;
int collectedFish = 0;
bool whirlpooled = false;
int[] whirlpoolLocation = new int[2];

for (int row = 0; row < size; row++)
{
    char[] data = Console.ReadLine()
        .ToCharArray();
    for (int col = 0; col < size; col++)
    {
        sea[row,col] = data[col];
    }
}

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (sea[row,col] == 'S')
        {
            shipRow = row;
            shipCol = col;
        }
    }
}

string input = null;
while ((input = Console.ReadLine()) != "collect the nets")
{
    int[] newShipLocation = NewShipLocation(input, shipRow,shipCol,size);
    if (char.IsDigit(sea[newShipLocation[0], newShipLocation[1]])) // Is Fish
    {
        char fishChar = sea[newShipLocation[0], newShipLocation[1]];
        int fish = fishChar - '0';
        collectedFish += fish;
        sea[shipRow, shipCol] = '-';
        sea[newShipLocation[0], newShipLocation[1]] = 'S';
        shipRow = newShipLocation[0];
        shipCol = newShipLocation[1];
    }
    else if (sea[newShipLocation[0], newShipLocation[1]] == 'W') // Is Whirlpool
    {
        whirlpoolLocation[0] = newShipLocation[0];
        whirlpoolLocation[1] = newShipLocation[1];
        whirlpooled = true;
    }
    else if (sea[newShipLocation[0], newShipLocation[1]] == '-') //Is nothing
    {
        sea[shipRow, shipCol] = '-';
        sea[newShipLocation[0], newShipLocation[1]] = 'S';
        shipRow = newShipLocation[0];
        shipCol = newShipLocation[1];
    }
}

if (!whirlpooled)
{
    if (collectedFish >= 20)
    {
        Console.WriteLine("Success! You managed to reach the quota!");
    }
    else
    {
        Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - collectedFish} tons of fish more.");
    }
    if (collectedFish > 0)
    {
        Console.WriteLine($"Amount of fish caught: {collectedFish} tons.");
    }
    PrintSea(sea, size);
}
else
{
    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{whirlpoolLocation[0]},{whirlpoolLocation[1]}]");
}


static int[] NewShipLocation(string input, int shipRow, int shipCol, int size)
{
    int[] newLocation = new int[2]
    {
        shipRow,shipCol
    };
    if (input == "up")
    {
        newLocation[0] = (shipRow - 1) < 0 ? size - 1 : shipRow - 1;
    }
    if (input == "down")
    {
        newLocation[0] = (shipRow + 1) > size - 1 ? 0 : shipRow + 1;
    }
    if (input == "left")
    {
        newLocation[1] = (shipCol - 1) < 0 ? size - 1 : shipCol - 1;
    }
    if (input == "right")
    {
        newLocation[1] = (shipCol + 1) > size - 1 ? 0 : shipCol + 1;
    }
    return newLocation;
}


static void PrintSea(char[,] sea, int size)
{
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write($"{sea[row, col]}");
        }
        Console.WriteLine();
    }
}