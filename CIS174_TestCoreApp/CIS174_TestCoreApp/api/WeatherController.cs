using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.api
{
    [Route("api/weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        public double Temperature()
        {
            int temp = 62;
            return temp;
        }

        [HttpGet("tocelcius")]
        public double FarenheitToCelsius(double degrees)
        {
            degrees = Temperature();
            degrees = ((degrees - 32) * 5) / 9;
            return degrees;
        }

        [HttpGet("tofarenheit")]
        public double CelsiusToFarenheit([FromQuery(Name = "degrees")] double degrees)
        {
            degrees = Temperature();
            degrees = (degrees * 1.8) + 32;
            return degrees;
        }
    }
}