int[] values = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int valuesToPush = values[0];
int valuesToPop = values[1];
int lookUpValue = values[2];

Stack<int> stack = new Stack<int>(input.Take(valuesToPush));

for (int i = 0; i < valuesToPop && stack.Count > 0; i++)
{
    stack.Pop();
}

if (stack.Contains(lookUpValue))
{
    Console.WriteLine("true");
}
else if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(stack.Min());
}

