using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace DeleteTestPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\dimit\Documents\words.txt";
            var originalLines = File.ReadAllLines(path);
            var updatedLines = new List<string>();
            string prefix = "test";
            foreach (var line in originalLines)
            {
                string[] infos = line.Split(' ');
                for (int i = 0; i < infos.Length; i++)
                {
                    if (infos[i].StartsWith(prefix))
                    {
                        infos[i] = infos[i].Remove(0, 4);
                    }

                }
                updatedLines.Add(string.Join(" ", infos));
            }

            File.WriteAllLines(path, updatedLines);

        }
    }
}