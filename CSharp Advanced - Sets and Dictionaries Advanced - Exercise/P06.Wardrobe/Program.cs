Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine()
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string colour = input[0];
    string[] items = input[1]
        .Split(",", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (wardrobe.ContainsKey(colour))
    {
        AddItems(wardrobe, colour, items);
    }
    else
    {
        wardrobe.Add(colour, new Dictionary<string, int>());
        AddItems(wardrobe, colour, items);

    }
}

string[] search = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
PrintAllItems(wardrobe, search);


void AddItems(Dictionary<string, Dictionary<string, int>> wardrobe, string colour, string[] items)
{

    foreach (var item in items)
    {
        if (wardrobe[colour].ContainsKey(item))
        {
            wardrobe[colour][item]++;
        }
        else
        {
            wardrobe[colour].Add(item, 1);
        }
    }

}

void PrintAllItems(Dictionary<string, Dictionary<string, int>> wardrobe, string[] search)
{
    foreach (var colour in wardrobe)
    {
        Console.WriteLine($"{colour.Key} clothes:");
        foreach(var item in colour.Value)
        {
            if (search[0] == colour.Key && search[1] == item.Key)
            {
                Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
            }
            else
            {
                Console.WriteLine($"* {item.Key} - {item.Value}");
            }

        }
    }
}
