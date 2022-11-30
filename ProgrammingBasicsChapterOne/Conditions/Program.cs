using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write an IF statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
            Console.WriteLine("Enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                firstNumber = firstNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
                Console.WriteLine($"First number: {firstNumber}. Second number: {secondNumber}");
            }
            else
            {
                Console.WriteLine($"First number {firstNumber} is smaller than the second {secondNumber}.");
            }


            //2.Write a program that shows the sign of the product of three real numbers without
            //calculating it. Use a sequence of if statements.
            Console.WriteLine("Enter your first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number: ");
            int c = Convert.ToInt32(Console.ReadLine());
           
            if ((a < 0 && b < 0 && c < 0) || (a < 0 && b >= 0 && c >= 0)) Console.WriteLine("-");
            else if ((a >= 0 && b >= 0 && c >= 0) || (a < 0 && b < 0 && c >= 0)) Console.WriteLine("+");
            else if ((a < 0 && b >= 0 && c < 0) || (a >= 0 && b < 0 && c < 0)) Console.WriteLine("+");
            else if ((a >= 0 && b < 0 && c >= 0) || (a >= 0 && b >= 0 && c < 0)) Console.WriteLine("-");
        }
    }
}
