using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Child : Person
    {
        private static int maxChildAge = 15;
        public Child(string name, byte age) : base(name, age)
        {
          
                if (age <= maxChildAge)
                {
                    this.age = age;
                }
                else {
                    throw new Exception($"Children should not be able to have age more than {maxChildAge}");
            }     
        }
    }
}
