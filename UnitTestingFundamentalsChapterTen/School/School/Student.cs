using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private int id;
        public Student(string name)
        {
            Name = name;
            Id = this.id; 
          
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new IOException("Name can not be null or empty!");
                }
                this.name = value;
            }

        }
        public int Id
        {
            get 
            {
                return id;
            }
            private set 
            {
                Random random = new Random();
                this.id = random.Next(10000, 99999);
            }
        }
    }
}
