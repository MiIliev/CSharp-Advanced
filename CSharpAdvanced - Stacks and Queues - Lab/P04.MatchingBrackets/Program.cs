namespace P04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            int currentIndex = 0;
            foreach (char c in input)
            {
                if (c == '(')
                {
                    stack.Push(currentIndex);
                }
                if (c == ')')
                {
                    int openingBracket = stack.Pop();
                    int closingBracket = currentIndex;
                    Console.WriteLine(input.Substring(openingBracket, closingBracket-openingBracket+1));
                }
                currentIndex++;
            }
        }
    }
}