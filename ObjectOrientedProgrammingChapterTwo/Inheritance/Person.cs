using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public string name;
        public byte age;
        private Guid Guid { get; set; }

        public Person(string name, byte age)
        {
            this.name = name;

            Guid = Guid.NewGuid();
        }
        public string Name
        {
            get
            {
                return name;

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
                if (value <= 0)
                {
                    throw new IOException("Age should be positive.");
                }
                age = value;
            }
        }
        public override string ToString()
        {
            return $"Person has name {Name} and it is {Age} years old. Person's ID is {Guid}";
        }

        public bool Equals(Person? other)
        {
            if (other == null)
                return false;
            return other is Person person &&
                   Name == person.Name &&
                   Age == person.Age && Guid == person.Guid;
        }
        public int CompareTo(Person? other)
        {
            if (other == null) return 1;

            return other.Age.CompareTo(this.Age);
        }
    }
}

