using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class PersonNewViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MinLength(2)]
        [StringLength(25)]
        public string LastName { get; set; }

        // Instruction was only "valid integer", so I assumed to allow only integers, and no further restrictions
        [Range(0, int.MaxValue, ErrorMessage = "Age entered must be a valid integer (whole numbers only).")]
        public int Age { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2018", ErrorMessage = "DOB must be between 1/1/1900 and 12/31/2018.")]
        public DateTime DateOfBirth { get; set; } = new DateTime(2018, 12, 31);

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(ConfirmPassword), ErrorMessage = "Password does not match the confirmation.")]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Confirmation does not match the password given.")]
        public string ConfirmPassword { get; set; }

        public string SelectedCountry { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{Value= "usa", Text="USA" },
            new SelectListItem{Value= "mexico", Text="Mexico" },
            new SelectListItem{Value= "canada", Text="Canada" }
        };
    }
}
