using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class AwardsViewModel
    {
        public bool IsActive { get; set; }

        public IEnumerable<string> Awards { get; set; }
    }
}
