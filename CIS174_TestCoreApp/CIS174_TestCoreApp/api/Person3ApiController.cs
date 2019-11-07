using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Filters;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.api
{
    [Route("api/person")]
    [ValidateModel, HandleException, FeatureEnabled(IsEnabled = true)]
    public class Person3ApiController : Controller
    {
        // Assignment 11.1

        public PersonService _service;
        public Person3ApiController(PersonService service)
        {
            _service = service;
        }

        [HttpGet("{id}"), EnsurePersonExists]
        public IActionResult Get(int id)
        {
            var detail = _service.GetPersonDetail(id);
            return Ok(detail);

        }

        [HttpPost("{id}"), EnsurePersonExists]
        public IActionResult Edit(int id, [FromBody] UpdatePersonCommand command)
        {
            _service.UpdatePerson(command);
            return Ok();
        }
    }
}