using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
         {
            ViewModel newmodel = new ViewModel();
            newmodel.Students = GetStudents();
            return View(newmodel);
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { FirstName = "Ricky", LastName = "Sears", Grade = 'B' });
            students.Add(new Student { FirstName = "Kaya", LastName = "Orwell", Grade = 'A' });
            students.Add(new Student { FirstName = "Jeremy", LastName = "Flint", Grade = 'D' });
            return students;
        }
    }
}