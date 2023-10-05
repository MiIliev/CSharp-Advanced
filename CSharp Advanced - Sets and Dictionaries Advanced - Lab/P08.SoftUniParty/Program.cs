string input = null;
HashSet<string> vipList = new HashSet<string>();
HashSet<string> regularList = new HashSet<string>();

while ((input = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(input[0]))
    {
        vipList.Add(input);
    }
    else
    {
        regularList.Add(input);
    }
}

while ((input = Console.ReadLine()) != "END")
{
    if (char.IsDigit(input[0]))
    {
        vipList.Remove(input);
    }
    else
    {
        regularList.Remove(input);
    }

}

Console.WriteLine(vipList.Count + regularList.Count);
foreach (string person in vipList)
{
    Console.WriteLine(person);
}
foreach (string person in regularList)
{
    Console.WriteLine(person);
}