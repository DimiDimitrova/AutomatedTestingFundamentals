namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", 20);
            Person pesho = new Person("Pesho", 20);
            if (ivan.Equals(pesho) == false)
            {
                Console.WriteLine($"People: {ivan.Name} and {pesho.Name} are not the same by id.");
            }

        }
    }
}