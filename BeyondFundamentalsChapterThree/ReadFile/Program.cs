using System;
using System.IO;

namespace ReadFileAndPrintOddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a program that reads a text file and prints on the console its odd lines.
            FileInfo fi = new FileInfo(@"C:\Users\dimit\Documents\ReadFileDemo.txt");
            FileStream fs = fi.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fs);
            string fileContent = sr.ReadLine();
            int lineNumber = 0;

            while (fileContent != null)
            {
                lineNumber++;
                if (lineNumber % 2 == 1)
                {
                    Console.WriteLine(fileContent);
                }
                fileContent = sr.ReadLine();
            }
            sr.Close();
            fs.Close();


        }
    }
}