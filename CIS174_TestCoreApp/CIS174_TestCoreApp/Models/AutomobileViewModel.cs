using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class AutomobileViewModel
    {
        public int ModelYear { get; set; }

        public string ModelName { get; set; }

        public string Manufacturer { get; set; }

        public IEnumerable<SelectListItem> ManufacturerList => new List<SelectListItem>
        {
            new SelectListItem
            {
                Value = "Ford",
                Text = "Ford"
            },
            new SelectListItem
            {
                Value = "FCA",
                Text = "Dodge"
            },
            new SelectListItem
            {
                Value = "Chevrolet",
                Text = "Chevy"
            },
        };

        public int Miles { get; set; }
    }
}
