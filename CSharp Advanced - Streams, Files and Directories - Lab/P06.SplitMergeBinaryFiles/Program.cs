using System.Collections.Generic;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";
            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }
        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] sourceBytes = File.ReadAllBytes(sourceFilePath);
            bool isEven = sourceBytes.Length % 2 == 0;

            using FileStream fileStreamFirst = new FileStream(partOneFilePath, FileMode.Create);
            fileStreamFirst.Write(sourceBytes, 0, isEven ? sourceBytes.Length / 2 : (sourceBytes.Length / 2) + 1);

            using FileStream fileStreamSecond = new FileStream(partTwoFilePath, FileMode.Create);
            fileStreamSecond.Write(sourceBytes, 0, sourceBytes.Length / 2);
        }
        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] firstArr = File.ReadAllBytes(partOneFilePath);
            byte[] secondArr = File.ReadAllBytes(partTwoFilePath);

            byte[] writeArr = new byte[firstArr.Length + secondArr.Length];
            firstArr.CopyTo(writeArr, 0);
            secondArr.CopyTo(writeArr, firstArr.Length);

            File.WriteAllBytes(joinedFilePath, writeArr);
        }
    }
}