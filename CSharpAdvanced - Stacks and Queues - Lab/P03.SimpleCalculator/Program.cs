namespace P03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            List<string> input = Console.ReadLine().Split(" ").Reverse().Where(x => x != null).ToList();
            Stack<string> stack = new Stack<string>(input);

            result = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                if (stack.Pop() == "+")
                {
                    result += int.Parse(stack.Pop());
                }
                else
                {
                    result -= int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(result);

        }
    }
}