namespace ConcatenateFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConcatenateFiles(@"C:\Users\dimit\Documents\ReadFileDemo.txt", @"C:\Users\dimit\Documents\SecondFile.txt"));
        }
        public static string ConcatenateFiles(string firstFilePath,string secondFilePath)
        {
            String line;
            try
            {
                string file = @"C:\Users\dimit\Documents\ConcatenateFilesDemo.txt";
                StreamWriter sw = new StreamWriter(@"C:\Users\dimit\Documents\ConcatenateFilesDemo.txt");
                StreamReader sr = new StreamReader(firstFilePath);
                line = sr.ReadLine();
                while (line != null)
                {
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                    if (line == null)
                    {
                        sr = new StreamReader(secondFilePath);
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            sw.WriteLine(line);
                            line = sr.ReadLine();
                        }
                    }
                }
               
                sr.Close();
                sw.Close();
                return file;
                
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}