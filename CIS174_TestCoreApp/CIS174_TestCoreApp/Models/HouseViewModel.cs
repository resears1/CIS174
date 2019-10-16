using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Models
{
    public class HouseViewModel
    {
        [Required]
        public int Bedrooms { get; set; }
        [Required]
        public int SquareFeet { get; set; }
        [Required]
        public DateTime DateBuilt { get; set; }
        [Required]
        public string Flooring { get; set; }
        [Required]
        public int Id { get; set; }

        public IEnumerable<HouseViewModel> Houses { get; set; }
    }
}
