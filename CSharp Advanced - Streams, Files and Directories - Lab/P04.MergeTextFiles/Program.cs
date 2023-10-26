namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using StreamReader firstReader = new StreamReader(firstInputFilePath);
            using StreamReader secondReader = new StreamReader(secondInputFilePath);

            string firstLine = firstReader.ReadLine();
            string secondLine = secondReader.ReadLine();

            using StreamWriter writer = new StreamWriter(outputFilePath);
            {
                while (firstLine != null && secondLine != null)
                {
                    writer.WriteLine(firstLine);
                    writer.WriteLine(secondLine);

                    firstLine = firstReader.ReadLine();
                    secondLine = secondReader.ReadLine();
                }
            }
        }
    }
}