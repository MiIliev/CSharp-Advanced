Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (students.ContainsKey(name))
    {
        students[name].Add(grade);
    }
    else
    {
        students.Add(name, new List<decimal>());
        students[name].Add(grade);
    }
}

foreach (var entry in students)
{
    decimal averageGrade = entry.Value.Average();
    Console.WriteLine($"{entry.Key} -> " +
        $"{string.Join(" ", entry.Value.Select(grade => $"{grade:F2}"))} " +
        $"(avg: {averageGrade:f2})");
}