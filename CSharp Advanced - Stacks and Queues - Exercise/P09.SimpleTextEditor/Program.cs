using System.Text;

int commandsCount = int.Parse(Console.ReadLine());
string text = string.Empty;
Stack<string> state = new Stack<string>();

for (int i = 0; i < commandsCount; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ")
        .ToArray();
    string command = input[0];

    if (command == "1")
    {
        state.Push(text);
        text += input[1];
    }
    else if (command == "2")
    {
        state.Push(text);
        int count = int.Parse(input[1]);
        text = text.Substring(0, text.Length - count);
    }
    else if (command == "3")
    {
        int index = int.Parse(input[1]);
        Console.WriteLine(text[index-1]); 
    }
    else if (command == "4")
    {
        text = state.Pop();
    }

}