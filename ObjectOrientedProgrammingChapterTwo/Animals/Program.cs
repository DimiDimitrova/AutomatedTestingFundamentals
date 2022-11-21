using System.Reflection;
using System.Xml.Linq;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sara", 2, "female");
            dog.printInfo();
            Kitten kitten = new Kitten("Kity", 3, "male");
            kitten.printInfo();

        }
    }
}