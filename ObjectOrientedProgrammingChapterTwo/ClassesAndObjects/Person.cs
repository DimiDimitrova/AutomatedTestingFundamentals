using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAndObjects
{
    internal class Person : IEquatable<Person>,IComparable<Person>
    {
        public string name { get; set; }
        public byte age { get; set; }
        private Guid guid { get; set; }


        public Person(string name, byte age) 
        {
            this.name = name;
            this.age = age;
            guid= Guid.NewGuid();
        }
      
        public override string ToString()
        {
            return $"Person has name {name} and it is {age} years old. Person's ID is {guid}";
        }

       
        public bool Equals(Person? other)
        {
            if (other == null)
                return false;
            return other is Person person &&
                   name == person.name &&
                   age == person.age && guid ==person.guid;
        }

        public int CompareTo(Person? other)
        {
            if (other == null) return 1;

            return other.age.CompareTo(this.age);
        }
    }
}
