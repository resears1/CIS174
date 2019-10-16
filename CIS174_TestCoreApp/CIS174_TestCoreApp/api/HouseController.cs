using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Models;

namespace WebApi1.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : Controller
    {
        public static IEnumerable<HouseViewModel> Houses()
        {
            List<HouseViewModel> houses = new List<HouseViewModel>();
            houses.Add(new HouseViewModel { Bedrooms = 4, SquareFeet = 1954, DateBuilt = new DateTime(1973, 05, 28), Flooring = "Carpet", Id = 1 });
            houses.Add(new HouseViewModel { Bedrooms = 3, SquareFeet = 1675, DateBuilt = new DateTime(2015, 10, 17), Flooring = "Hardwood", Id = 2 });
            return houses;
        }

        [HttpGet("")]
        public IActionResult ListHouses()
        {
            return Json(Ok(Houses()));
        }

        [HttpGet("{id}")]
        public IActionResult ListHouseById(int id)
        {
            if (id <= Houses().Count())
            {
                return Ok(Houses().ElementAt(id - 1));
            }
            else
            {
                return NotFound();
            }

        }

        
        [HttpPost("create")]
        public IActionResult Create([FromBody] HouseViewModel house)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Create(house);
            return Ok(house);
        }
    }
}