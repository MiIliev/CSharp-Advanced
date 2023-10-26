int n = int.Parse(Console.ReadLine());
List<int> allNumbers = new List<int>();

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    allNumbers.Add(input);
}
Dictionary<int, int> numberCounter =  new Dictionary<int, int>();

foreach (int number in allNumbers)
{
    if (numberCounter.ContainsKey(number))
    {
        numberCounter[number]++;
    }
    else
    {
        numberCounter.Add(number, 1);
    }
}

Console.WriteLine(numberCounter.First(x => x.Value % 2 == 0).Key);