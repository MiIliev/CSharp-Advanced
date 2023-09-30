int petrolPumpsCount = int.Parse(Console.ReadLine());

Queue<int[]> pumps = new Queue<int[]>();
for (int i = 0; i < petrolPumpsCount; i++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();
    pumps.Enqueue(input);
}

int bestRoute = 0;

while (true)
{
    int remainingPetrol = 0;
    bool pumpsPassed = false;
    int pumpsCounter = 0;

    foreach (var pump in pumps)
    {
        remainingPetrol += pump[0];
        int distance = pump[1];

        if (distance > remainingPetrol)
        {
            pumpsCounter = 0;
            remainingPetrol = 0;
            break;
        }
        else
        {
            remainingPetrol -= distance;
            pumpsCounter++;
            if (pumpsCounter == pumps.Count)
            {
                pumpsPassed = true;
            }
        }
    }
    if (pumpsPassed)
    {
        break;
    }
    pumps.Enqueue(pumps.Dequeue());
    bestRoute++;
}
Console.WriteLine(bestRoute);