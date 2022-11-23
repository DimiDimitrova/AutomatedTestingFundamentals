using System.Reflection;
using System.Xml.Linq;
using LINQAndLambdaExpression;

namespace ReflectionAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].Namespace.StartsWith("Work"))
                {
                    Console.WriteLine(types[i].Name);
                }

            }
            Console.WriteLine($"Assembly Name: {assembly.GetName().Name}");
            Console.WriteLine($"Version: {assembly.GetName().Version}");

            Worker worker = new Worker();
            var instanceWorker = worker.GetType().Name;
            Console.WriteLine(instanceWorker);

            Type type = typeof(Worker);
            var fullNameProperty = type.GetProperty("FullName");

            fullNameProperty.SetValue(worker, "Ivan draganov");
            Console.WriteLine(fullNameProperty.GetValue(worker));
        }
    }
}