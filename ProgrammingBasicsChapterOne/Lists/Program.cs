using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program that allocates array of 20 integers and initializes each element by its
            //index multiplied by 5.Print the obtained array on the console.
            int[] intArray = new int[20];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 5;
            }
            foreach (int number in intArray)
            {
                Console.WriteLine(number);
            }
            //2.Solve the same problem but use a list instead of the array.
            List<int> list = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i * 5);
            }
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
        }
    }
}