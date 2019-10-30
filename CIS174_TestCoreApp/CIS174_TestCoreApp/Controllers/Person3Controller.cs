using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class Person3Controller : Controller
    {
        public PersonService _service;
        public Person3Controller(PersonService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var models = _service.GetPeople();

            return View(models);
        }

        public IActionResult View(int id)
        {
            var model = _service.GetPersonDetail(id);
 
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new CreatePersonCommand());
        }

        [HttpPost]
        public IActionResult Create(CreatePersonCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var id = _service.CreatePerson(command);
                    return RedirectToAction(nameof(View), new { id = id});
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "An error occured saving the person"
                    );
            }
            return View(command);
        }

        public IActionResult Edit(int id)
        {
            var model = _service.GetPersonForUpdate(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(UpdatePersonCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.UpdatePerson(command);
                    return RedirectToAction(nameof(View), new { id = command.Id });
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "An error occured saving the person"
                    );
            }

            return View(command);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.DeletePerson(id);

            return RedirectToAction(nameof(Index));
        }

    }
}