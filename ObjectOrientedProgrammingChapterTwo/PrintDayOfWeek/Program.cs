namespace PrintDayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}