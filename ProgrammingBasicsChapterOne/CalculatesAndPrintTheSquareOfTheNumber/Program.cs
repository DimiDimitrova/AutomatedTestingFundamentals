namespace CalculatesAndPrintTheSquareOfTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 32346;
            double squareOfNumber = number * number;
            Console.WriteLine(squareOfNumber);
            int? nullInt = null;
            Console.WriteLine("This is the integer with Null value -> {nullInt}");
            nullInt = 5;
            Console.WriteLine("This is the integer with value 5 -> {0}",nullInt);


        }
    }
}