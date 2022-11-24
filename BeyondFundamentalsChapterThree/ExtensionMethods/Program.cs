
using System.Collections;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] d = { 5, 6, 7 };
            Console.WriteLine(d.Sum());
            List<double> n = new List<double>();
            n.Add(5);
            n.Add(6);
            Console.WriteLine(n.Sum());
            int[] i = { 9, 2, 3, 1, 9, 8, 6, 4 };
            Console.WriteLine(i.Min());
            Console.WriteLine(i.Max());
            Console.WriteLine(d.Average());


        }



    }
}