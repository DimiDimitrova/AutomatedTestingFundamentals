namespace ReadFileAndWriteItWithLineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"C:\Users\dimit\Documents\ReadFileDemo.txt");
            FileStream fs = fi.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fs);
            string fileContent = sr.ReadLine();
            int lineNumber = 0;
            StreamWriter sw = new StreamWriter(@"C:\Users\dimit\Documents\LineNumbersFile.txt");
            while (fileContent != null)
            {
                lineNumber++;
                sw.WriteLine("Line {0}: {1}", lineNumber, fileContent);              
                fileContent = sr.ReadLine();
            }
            Console.WriteLine("Finish!");
            sr.Close();
            sw.Close();
            fs.Close();
        }
    }
}