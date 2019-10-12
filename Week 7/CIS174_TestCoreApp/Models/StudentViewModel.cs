using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Grade { get; set; }
    }

    public class ViewModel
    {
        public IEnumerable<Student> Students { get; set; }
    }
}

