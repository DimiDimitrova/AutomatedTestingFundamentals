using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animals
{
    public class Animal
    {
        private string name;
        private byte age;
        private string gender;
        public Animal(string name, byte age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if ((value.Length == 0 || value == null))
                {
                    throw new IOException("Invalid input!");
                }
                name = value;
            }
        }
        public virtual byte Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new IOException("Invalid input!");
                }
                age = value;
            }
        }
        public virtual string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "female":
                        gender = value;
                        break;
                    case "male":
                        gender = value;
                        break;
                    default:
                        throw new IOException("Invalid input!");
                        break;
                }

            }
        }


        public virtual void ProduceSound()
        {
            Console.WriteLine("I am an animal.");
        }

        public virtual void printInfo()
        {
            string? className = MethodBase.GetCurrentMethod()?.DeclaringType?.Name;
            Console.WriteLine($"{this.GetType().Name}");
            Console.WriteLine($"{Name} - {Age} - {Gender}");
            ProduceSound();
        }


    }
}

