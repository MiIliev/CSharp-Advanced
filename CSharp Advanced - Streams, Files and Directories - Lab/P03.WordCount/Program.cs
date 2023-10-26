using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using StreamReader wordReader = new StreamReader(wordsFilePath);
            string[] words = wordReader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();

            using StreamReader textReader = new StreamReader(textFilePath);
            string text = textReader.ReadToEnd();

            Dictionary<string, int> wordCounter = new Dictionary<string, int>();
            Regex pattern = new Regex(@"[A-z]+");
            MatchCollection matches = pattern.Matches(text);
            foreach (var word in words)
            {
                foreach (Match match in matches)
                {
                    if (match.Value.ToLower() == word)
                    {
                        if (!wordCounter.ContainsKey(word)) wordCounter.Add(word, 0);
                        wordCounter[word]++;
                    }
                }
            }

            using StreamWriter writer = new StreamWriter(outputFilePath);
            {
                foreach( var word in wordCounter.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}