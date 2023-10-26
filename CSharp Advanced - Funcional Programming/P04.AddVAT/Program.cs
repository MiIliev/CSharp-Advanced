Func<double, double> addVat = x => x = x * 1.2;
double[] input = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .Select(addVat)
    .ToArray();

foreach(double number in input)
{
    Console.WriteLine($"{number:f2}");
}    