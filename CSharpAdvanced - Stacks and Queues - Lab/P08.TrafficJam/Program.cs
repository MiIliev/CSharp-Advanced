int n = int.Parse(Console.ReadLine());
string input = null;
Queue<string> cars = new Queue<string>();
int carCounter = 0;
while ((input = Console.ReadLine()) != "end")
{
    if (input != "green")
    {
        cars.Enqueue(input);
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            carCounter++;
        }
    }
}
Console.WriteLine($"{carCounter} cars passed the crossroads.");