SortedDictionary<char, int> letterCounter = new SortedDictionary<char, int>();
string text = Console.ReadLine();

foreach (char letter in text.ToCharArray())
{
    if (letterCounter.ContainsKey(letter))
    {
        letterCounter[letter]++;
    }
    else
    {
        letterCounter.Add(letter, 1);
    }
}

foreach (char letter in letterCounter.Keys)
{
    Console.WriteLine($"{letter}: {letterCounter[letter]} time/s");
}