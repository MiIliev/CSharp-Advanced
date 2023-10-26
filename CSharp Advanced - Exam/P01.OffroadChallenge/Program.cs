using System.Text;

Stack<int> initialFuel = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
Queue<int> addConsumption = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
Queue<int> neededFuel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
List<string> altitudesReached = new List<string>();

int altitudeCounter = 0;
while(initialFuel.Any() && addConsumption.Any())
{
    int currFuel = initialFuel.Pop() - addConsumption.Dequeue();

    if (currFuel < neededFuel.Peek())
    {
        Console.WriteLine($"John did not reach: Altitude {altitudeCounter + 1}");
        break;
    }
    else if (currFuel >= neededFuel.Dequeue())
    {
        Console.WriteLine($"John has reached: Altitude {++altitudeCounter}");
        altitudesReached.Add($"Altitude {altitudeCounter}");
    }
}

if (altitudeCounter > 0 && altitudeCounter < 4)
{
    Console.WriteLine($"John failed to reach the top." +
        $"\nReached altitudes: {string.Join(", ", altitudesReached)}");
}
else if (altitudeCounter == 4)
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!.");
}
else
{
    Console.WriteLine("John failed to reach the top.\nJohn didn't reach any altitude.");
}
