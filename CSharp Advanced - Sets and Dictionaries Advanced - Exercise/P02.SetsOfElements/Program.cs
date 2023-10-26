int[] length = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int firstLength = length[0];
int secondLength = length[1];
Dictionary<string, int[]> sets = new Dictionary<string, int[]>();
sets.Add("firstSet", new int[firstLength]);
sets.Add("secondSet", new int[secondLength]);

for (int i = 0; i < firstLength; i++)
{
    int input = int.Parse(Console.ReadLine());
    sets["firstSet"][i] = input;
}

for (int i = 0; i < secondLength; i++)
{
    int input = int.Parse(Console.ReadLine());
    sets["secondSet"][i] = input;
}

HashSet<int> result = new HashSet<int>();


foreach (var number in sets["firstSet"])
{
    if (sets["secondSet"].Contains(number))
    {
        result.Add(number);
    }
}

Console.WriteLine(string.Join(" ", result));