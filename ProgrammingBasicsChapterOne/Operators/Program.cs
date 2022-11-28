using System.Drawing;
using System.Security.Cryptography;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Write an expression that checks if given integer is odd or even.
            Console.WriteLine("Input your number: \n");
            int number = Convert.ToInt16(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Number {number} is even.");
            }
            else
            {
                Console.WriteLine($"Number {number} is odd.");
            }
            //2.Write an expression that calculates rectangle’s area by given width and height.
            Console.WriteLine("Enter rectangle's width \n");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rectangle's height: \n");
            double height = Convert.ToDouble(Console.ReadLine());
            double rectangleArea = width * height;
            Console.WriteLine($"Rectangle's area is: {rectangleArea}");


            //3.Write an expression that checks if given positive integer number n(n ≤ 100) is prime.
            //E.g. 37 is prime.

            //4.Write an expression that calculates trapezoid's area by given sides a and b and height h.
            Console.WriteLine("Enter trapezoid's side a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's side b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter trapezoid's height h:");
            double h = Convert.ToDouble(Console.ReadLine());
            //  1/2(a+b)*h
            double trapezoidArea = ((a + b) / 2) * h;
            Console.WriteLine($"Trapezoid's area is: {trapezoidArea}");


            int fistNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());

            if (fistNumber > b)
            {
                fistNumber = fistNumber + secondNumber;
                secondNumber = fistNumber - secondNumber;
                fistNumber = fistNumber - secondNumber;
            }

            Console.WriteLine("{0},{1}", fistNumber, secondNumber);


        }
    }
}