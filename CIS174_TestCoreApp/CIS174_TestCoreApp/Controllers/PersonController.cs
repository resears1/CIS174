using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class PersoOldController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CreatePersonOldViewModel
            {
                School = "DMACC"
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(CreatePersonOldViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}