using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child : Person
    {
        private static int maxChildAge = 15;
        public Child(string name, byte age) : base(name, age)
        {
        }
        public override byte Age
        {
            get => Age;

            set
            {
                if (value> maxChildAge)
                {
                    throw new IOException($"Children should not be able to have age more than {maxChildAge}");
                }
                base.Age = value;
            }
        }
    }
}
