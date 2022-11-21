using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, byte age, string gender) : base(name, age, gender)
        {
        }
        public override string Gender
        {
            get => base.Gender;
            set => base.Gender = "female";
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miau");
        }
    }
}
