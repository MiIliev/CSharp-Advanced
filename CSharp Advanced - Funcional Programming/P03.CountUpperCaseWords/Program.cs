Func<string, bool> isUpperCase = x => char.IsUpper(x[0]);

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(x => isUpperCase(x))
    .ToArray();

foreach(string word in input)
{
    Console.WriteLine(word);
}    