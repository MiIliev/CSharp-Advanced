int foodQuantity = int.Parse(Console.ReadLine());
int[] ordersArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> orders = new Queue<int>(ordersArray);

Console.WriteLine(orders.Max());
while(orders.Count > 0)
{
    if (orders.Peek() > foodQuantity)
    {
        break;
    }
    foodQuantity -= orders.Dequeue();
}
if (orders.Count > 0)
{
    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
}
else
{
    Console.WriteLine("Orders complete");
}