using System.ComponentModel;
using System.Reflection;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2,3));
        }
        //        Write a method GetMax() with two parameters that returns the bigger of two integers.
        //Write a program that passes two integers and prints the biggest of them using the 
        //method GetMax().
        public static int GetMax(int a, int b) 
        {
           int theBiggerNuber =  Math.Max(a, b);
            return theBiggerNuber;
        }

    }
}