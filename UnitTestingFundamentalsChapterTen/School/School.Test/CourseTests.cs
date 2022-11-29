namespace School.Test
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        
        public void ErrorMessageThrowed_When_AddMoreStudentsThanCapacity()
        {
            const int MAX_CAPACITY = 30;
            Student ivan = new Student("Ivan");
          
            Course math = new Course();
            for (int i = 0; i < MAX_CAPACITY -1; i++)
            {
                math.AddStudent(ivan);
                
            }
            
          
            Action test = () => math.AddStudent(ivan);
            Assert.ThrowsException<ArgumentException>(test);
        }


    }
}


