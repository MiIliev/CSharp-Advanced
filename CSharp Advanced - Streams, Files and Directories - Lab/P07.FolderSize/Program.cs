namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double sum = 0;

            DirectoryInfo dir = new DirectoryInfo(folderPath);
            FileInfo[] info = dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo fi in info) sum += fi.Length;

            sum = sum / 1024 / 1024;
            File.WriteAllText(outputFilePath, sum.ToString());
        }
    }
}