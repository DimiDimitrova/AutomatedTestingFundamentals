using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Notify();
    public class Timer
    {
        private int seconds;
        public event Notify Reminder;
        public Timer(int seconds)
        {
            Seconds = seconds;
        }
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                seconds = value;
            }
        }

        public void ReminderMessage(string message)
        {
            Console.WriteLine(message);
            OnReminderMessageRun();
        }
        protected virtual void OnReminderMessageRun()
        {
            int sec= Seconds * 1000;
            var timer = new Timer(sec);
            Reminder?.Invoke();
        }
    }
}
