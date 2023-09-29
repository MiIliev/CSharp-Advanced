namespace P02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int result = 0;
            string input = null;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] command = input.Split(" ").ToArray();
                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                if (command[0] == "remove")
                {
                    int n = int.Parse(command[1]);
                    if (n <= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (stack.Count == 0)
                            {
                                break;
                            }
                            stack.Pop();
                        }
                    }
                    
                }
            }
            while (stack.Count > 0)
            {
                result += stack.Pop();
            }
            Console.WriteLine($"Sum: {result}");
        }
    }
}