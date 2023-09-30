int[] values = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int valuesToEnque = values[0];
int valuesToDequeue = values[1];
int lookUpValue = values[2];

Queue<int> queue = new Queue<int>(numbers.Take(valuesToEnque));

for (int i = 0; i < valuesToDequeue && queue.Count > 0; i++)
{
    queue.Dequeue();
}

if (queue.Contains(lookUpValue))
{
    Console.WriteLine("true");
}
else if (queue.Count == 0)
{
    Console.WriteLine(0);

}
else
{
    Console.WriteLine(queue.Min());
}