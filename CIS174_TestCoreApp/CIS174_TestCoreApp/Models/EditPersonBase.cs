using CIS174_TestCoreApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class EditPersonBase
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(75)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(75)]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; } = new DateTime(2018, 12, 31);

        [Required]
        [StringLength(75)]
        public string City { get; set; }

        [Required]
        [StringLength(75)]
        public string State { get; set; }

        public ICollection<Accomplishment> Accomplishments { get; set; }
    }
}
