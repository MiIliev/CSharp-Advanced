int[] clothesArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int rackCapacity = int.Parse(Console.ReadLine());
int capacityRemaining = rackCapacity;
int racksUsed = 1;

Stack<int> clothes =  new Stack<int>(clothesArray);

while (clothes.Count > 0)
{
    if (capacityRemaining >= clothes.Peek())
    {
        capacityRemaining -= clothes.Pop();
    }
    else
    {
        racksUsed++;
        capacityRemaining = rackCapacity - clothes.Pop();
    }
}
Console.WriteLine(racksUsed);
