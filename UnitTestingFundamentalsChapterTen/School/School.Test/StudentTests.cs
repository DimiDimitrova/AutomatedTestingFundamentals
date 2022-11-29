using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Test
{

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void ErrorMessageThrew_When_StudentNameIsNullOrEmpty()
        {
            Student student;
            Action test = () => student= new Student(""); 
            Assert.ThrowsException<IOException>(test);          

        }
    }
}
