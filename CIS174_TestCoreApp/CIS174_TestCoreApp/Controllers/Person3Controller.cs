using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CIS174_TestCoreApp.Controllers
{
    public class Person3Controller : Controller
    {
        private readonly PersonService _service;
        private readonly UserManager<ApplicationUser> _userService;
        private readonly IAuthorizationService _authService;
        private readonly ILogger<Person3Controller> _logger;

        public Person3Controller(
            PersonService service,
            UserManager<ApplicationUser> userService,
            IAuthorizationService authService, ILogger<Person3Controller> logger)
        {
            _service = service;
            _userService = userService;
            _authService = authService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var models = _service.GetPeople();
            if (models == null)
            {
                _logger.LogError("Could not view people");
            }
            return View(models);
        }

        [Authorize]
        public IActionResult Accomplishments()
        {
            var model = _service.GetAccomplishments();
            if (model == null)
            {
                _logger.LogError("Could not view accomplishments");
            }
            return View(model);
        }

        public IActionResult View(int id)
        {
            var model = _service.GetPersonDetail(id);
            if (model == null)
            {
                _logger.LogError("Could not view {PersonId}", id);
            }
            return View(model);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View(new CreatePersonCommand());
        }

        [HttpPost, Authorize]
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

                _logger.LogWarning("Could not save person");
            }
            return View(command);
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var model = _service.GetPersonForUpdate(id);
            if (model == null)
            {
                _logger.LogWarning("Person {PersonId} could not be edited.", id);
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
                _logger.LogWarning("Person {PersonId} could not be edited.");
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