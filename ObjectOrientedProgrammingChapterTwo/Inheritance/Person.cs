using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person : IEquatable<Person>, IComparable<Person>
    {
        public string Name {
            get
            {
                return this.Name;
                    }
            set {
                this.Name = value;
            } }
        private byte age;
        private Guid Guid { get; set; }

        public Person(string name, byte age)
        {
            Guid = Guid.NewGuid();
        }
       
        public virtual byte Age 
        {
            get 
            {
                return this.age;
            }
            set {
                this.age = value;
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
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inheritance
//{
//    public class Person : IEquatable<Person>, IComparable<Person>
//    {
//        public string Name { get; set; }
//        public virtual byte Age { get; set; }
//        private Guid Guid { get; set; }

//        public Person(string name, byte age)
//        {
//            this.Name = name;
//            this.Age = age;
//            Guid = Guid.NewGuid();
//        }
//        public override string ToString()
//        {
//            return $"Person has name {Name} and it is {Age} years old. Person's ID is {Guid}";
//        }

//        public bool Equals(Person? other)
//        {
//            if (other == null)
//                return false;
//            return other is Person person &&
//                   Name == person.Name &&
//                   Age == person.Age && Guid == person.Guid;
//        }
//        public int CompareTo(Person? other)
//        {
//            if (other == null) return 1;

//            return other.Age.CompareTo(this.Age);
//        }
//    }
//}

