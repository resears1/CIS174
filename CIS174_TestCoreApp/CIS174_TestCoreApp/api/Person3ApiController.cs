using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Filters;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CIS174_TestCoreApp.api
{
    [Route("api/person")]
    [ValidateModel, HandleException, FeatureEnabled(IsEnabled = true)]
    public class Person3ApiController : Controller
    {
        // Assignment 11.1

        public PersonService _service;
        public ILogger<Person3ApiController> _logger;
        public Person3ApiController(PersonService service, ILogger<Person3ApiController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("{id}"), EnsurePersonExists]
        public IActionResult Get(int id)
        {
            var detail = _service.GetPersonDetail(id);
            if (detail == null)
            {
                _logger.LogWarning("Person ID {PersonId} not found", id);
                return NotFound();
            }
            return Ok(detail);

        }

        [HttpPost("{id}"), EnsurePersonExists]
        public IActionResult Edit(int id, [FromBody] UpdatePersonCommand command)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Person ID {PersonId} could not be updated", id);
            }

            _service.UpdatePerson(command);
            return Ok();
        }
    }
}