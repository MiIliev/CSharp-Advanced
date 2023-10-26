Func<int, bool> evenNumberChecker = x => x % 2 == 0;
int[] input = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(evenNumberChecker)
    .OrderBy(x => x)
    .ToArray();

Console.WriteLine(string.Join(",", input));