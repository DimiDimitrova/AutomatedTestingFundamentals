using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace CompareTwoTextFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[] firstFile = File.ReadAllLines(@"C:\Users\dimit\Documents\ReadFileDemo.txt");
            String[] secondFile = File.ReadAllLines(@"C:\Users\dimit\Documents\ComparedFile.txt");
            int countDifferent = 0;
            int countSame = 0;

            if (firstFile.Length == secondFile.Length)
            {
                for (int i = 0; i < firstFile.Length; i++)
                {
                    if (firstFile[i] != secondFile[i])
                    {
                        countDifferent++;
                    }
                    else
                    {
                        countSame++;
                    }
                }
                Console.WriteLine($"Lines that are the same: {countSame}");
                Console.WriteLine($"Lines that are different: {countDifferent}");
            }
            else
            {
                Console.WriteLine(firstFile.Length);
                Console.WriteLine(secondFile.Length);
                Console.WriteLine("The files should have an equal number of lines!");
            }



        }
    }
}