namespace EvenLines
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StringBuilder sb = new StringBuilder();
            char[] replaceChars = { '-', ',', '.', '!', '?' };

            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                string[] reversedWords = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Array.Reverse(reversedWords);
                string reversedLine = string.Join(" ",reversedWords);
                foreach(char c in replaceChars)
                {
                    reversedLine = reversedLine.Replace(c, '@');
                }
                sb.AppendLine(reversedLine);
                line = reader.ReadLine();
            }
            return sb.ToString();

        }
    }
}