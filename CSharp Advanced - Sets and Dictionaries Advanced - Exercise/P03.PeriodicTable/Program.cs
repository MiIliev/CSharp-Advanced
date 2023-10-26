int n = int.Parse(Console.ReadLine());
SortedSet<string> result = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    string[] elements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    foreach(string element in elements)
    {
        result.Add(element);
    }
}

Console.WriteLine(string.Join(" ", result));