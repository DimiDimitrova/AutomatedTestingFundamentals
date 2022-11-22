using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace DeleteTestPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"C:\Users\dimit\Documents\words.txt");
            FileStream fs = fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string fileContent = sr.ReadLine();

            while (fileContent != null)
            {
                String[] line = fileContent.Split(" ");
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i].StartsWith("test"))
                    {
                        line[i] = "";
                    }
                }
                // da se dovurshi
               

                fileContent = sr.ReadLine();
            }
            sr.Close();
            fs.Close();

        }
    }
}