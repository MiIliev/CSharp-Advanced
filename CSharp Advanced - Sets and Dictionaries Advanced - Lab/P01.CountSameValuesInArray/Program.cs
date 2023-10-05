double[] data = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

Dictionary<double, int> dict = new Dictionary<double, int>();

foreach (double number in data)
{
    if (dict.ContainsKey(number))
    {
        dict[number]++;
    }
    else
    {
        dict.Add(number, 1);
    }
}

foreach (var entry in dict)
{
    Console.WriteLine($"{entry.Key} - {entry.Value} times");
}