using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Grade { get; set; }
        public int AccessLevel { get; set; }
    }
}
