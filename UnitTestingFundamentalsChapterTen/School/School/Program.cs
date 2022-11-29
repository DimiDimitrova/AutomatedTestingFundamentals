namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student pesho = new Student("Pesho");
            Student gosho = new Student("Gosho");
            Student asen = new Student("Asen");
            Student ivan = new Student("Ivan");
            var math = new Course();
            math.AddStudent(pesho);
            math.AddStudent(gosho);
            math.AddStudent(asen);
            var history = new Course();
            history.AddStudent(pesho);
            history.AddStudent(gosho);
            history.AddStudent(asen);
            math.ListOfStudentsInTheCourse();
          


           
          
        }
    }
}