namespace PrimitiveDataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort ushortValue = 51240;
            sbyte sbyteValue = -113;
            int intValue = 4735941;
            byte byteValue = 87;
            short shortValue = -20000;
            Console.WriteLine($"{ushortValue},{sbyteValue},{intValue}, {byteValue}, {shortValue}");
            bool isFemale = true;
            string hello = "Hello";
            string world = "World";
            object hiWorld = hello + " " + world;
            string helloWorld = (string)hiWorld;


            int firstDigit = 5;
            int secondDigit = 10;
            int temp = firstDigit;
            firstDigit = secondDigit;
            secondDigit = temp;
            Console.WriteLine($"{firstDigit}, {secondDigit}");
            int x = 6;
            int y = 4;
            Console.WriteLine(y *= 2); // 8
            int z = y = 3; // y=3 and z=3 
            Console.WriteLine(z); // 3
            Console.WriteLine(x |= 1); // 7
            Console.WriteLine(x += 3); // 10
            Console.WriteLine(x /= 2); // 5
            string firstName;
            string familyName;
            byte age;
            char gender;
            uint id;
        }
        
    }
}