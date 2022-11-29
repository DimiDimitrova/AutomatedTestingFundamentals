using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School
{
    public class Course
    {
        private List<Student> students;
        private const int MAX_STUDENTS = 30;
        public Course()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
                if (students.Count < MAX_STUDENTS - 1)
                {
                    students.Add(student);
                }
                else
                {
                    throw new ArgumentException($"Students in a course should be less than {MAX_STUDENTS}");
                }
        }


        public void RemoveStudent(Student student)
        {
            if (students.Count > 0)
            {
                if (students.Contains(student))
                {
                    students.Remove(student);
                }
            }
        }

        public void ListOfStudentsInTheCourse()
        {
            foreach (var s in students)
            {
                Console.WriteLine($"Student name: {s.Name} and ID {s.Id}");
            }
        }



    }
}

