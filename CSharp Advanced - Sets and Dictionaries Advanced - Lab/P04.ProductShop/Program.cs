string input = null;
SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

while ((input = Console.ReadLine()) != "Revision")
{
    string[] command = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string shop = command[0];
    string product = command[1];
    double price = double.Parse(command[2]);

    if (shops.ContainsKey(shop))
    {
        shops[shop].Add(product, price);
    }
    else
    {
        shops.Add(shop, new Dictionary<string, double>());
        shops[shop].Add(product, price);
    }
}

foreach (var shop in shops)
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}