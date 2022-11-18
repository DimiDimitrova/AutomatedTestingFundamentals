namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Write a program that prints all the numbers from 1 to 30.
            int minSize = 1;
            int maxSize = 30;
            for (int i = minSize; i <= maxSize; i++)
            {
                Console.WriteLine(i);
            }
            //2.Write a program that prints all the numbers from 1 to 30, that are not divisible by 3
            //and 7 at the same time.
            for (int i = minSize; i < maxSize; i++)
            {
                if (i % 3 == 1 && i % 7 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}