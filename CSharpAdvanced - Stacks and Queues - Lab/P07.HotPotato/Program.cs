List<string> names = Console.ReadLine().Split(" ").ToList();
int toss = int.Parse(Console.ReadLine());
Queue<string> children = new Queue<string>(names);
int currentToss = 0;

while (children.Count > 1)
{
    currentToss++;
    if (currentToss != toss)
    {
        children.Enqueue(children.Dequeue());
    }
    else
    {
        Console.WriteLine($"Removed {children.Dequeue()}");
        currentToss = 0;
    }
}
Console.WriteLine($"Last is {children.Dequeue()}");
