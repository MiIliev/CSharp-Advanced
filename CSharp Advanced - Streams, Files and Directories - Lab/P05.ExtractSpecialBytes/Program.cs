using System.ComponentModel;
using System.Text;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] byteArr = File.ReadAllBytes(binaryFilePath);

            using StreamReader searchReader = new StreamReader(bytesFilePath);
            string[] bytesToSearch = searchReader.ReadToEnd()
                .Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (byte b in byteArr)
            {
                if (bytesToSearch.Contains(b.ToString()))
                {
                    sb.Append(b.ToString());
                }
            }

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine(sb.ToString().Trim());
            }

            //To be fixed
        }
    }
}