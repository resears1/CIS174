using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
       public IActionResult Index()
        {
            var viewModel = new StudentViewModel
            {
                AccessLevel = 5,
                FirstName = "Ricky",
                LastName = "Sears",
                Grade = 'B'
            };

            return View(viewModel);
        }
    }
}