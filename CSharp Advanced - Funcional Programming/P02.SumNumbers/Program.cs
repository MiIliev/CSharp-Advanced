int[] input = Console.ReadLine()
    .Split(',', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Console.WriteLine
    ($"{input.Length}\n" +
    $"{input.Sum()}");