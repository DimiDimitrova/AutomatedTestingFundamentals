using System;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerators = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomGenerators.Next(100, 200));
            }

            DateTime dateTime = DateTime.Today;
            Console.WriteLine(dateTime.DayOfWeek);

            Person ivan = new Person("Ivan", 20);
            Person pesho = new Person("Pesho", 20);
            if (ivan.Equals(pesho) == false)
            {
                Console.WriteLine($"People: {ivan.name} and {pesho.name} are not the same by id.");
            }

            //List<Person> persons = new List<Person>();
            //persons.Add(new Person("Ivan", 20));
            //persons.Add(new Person("Ivan", 30));

            //Child child = new Child("Pesh",20);
            //Console.WriteLine(child.age);

        }
    }
}