namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var timer = new Timer(3);
                timer.Reminder += timer_ProcessCompleted;
                timer.ReminderMessage("You should learn new things :)");
                Thread.Sleep(1000);
            }
           
        }
        public static void timer_ProcessCompleted()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($"Task completed! {date}");
        }
        
    }
}