string input = null;
HashSet<string> remainingCars = new HashSet<string>();

while ((input = Console.ReadLine()) != "END")
{
    string[] data = input
        .Split(", ")
        .ToArray();
    string direction = data[0];
    string plateNumber = data[1];

    if (direction == "IN")
    {
        remainingCars.Add(plateNumber);
    }
    else if (direction == "OUT")
    {
        remainingCars.Remove(plateNumber);
    }
}

if (remainingCars.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (string car in remainingCars)
    {
        Console.WriteLine(car);
    }
}

