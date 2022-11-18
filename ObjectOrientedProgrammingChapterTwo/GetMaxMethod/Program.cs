namespace GetMaxMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2, 3));
        }
        public static int GetMax(int a, int b)
        {
            int theBiggerNuber = Math.Max(a, b);
            return theBiggerNuber;
        }
    }
}
