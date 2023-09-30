string[] songs = Console.ReadLine()
    .Split(", ")
    .ToArray();
Queue<string> playlist = new Queue<string>(songs);

while (playlist.Count > 0)
{
    string[] input = Console.ReadLine()
        .Split(" ")
        .ToArray();
    Queue<string> command = new Queue<string>(input);
    
    if (command.Peek() == "Play")
    {
        command.Dequeue();
        playlist.Dequeue();
    }
    else if (command.Peek() == "Add")
    {
        command.Dequeue();
        string songName = string.Join(" ", command);
        if (playlist.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            playlist.Enqueue(songName);
        }
    }
    else if (command.Peek() == "Show")
    {
        command.Dequeue();
        Console.WriteLine(string.Join(", ", playlist));
    }
}
Console.WriteLine("No more songs!");