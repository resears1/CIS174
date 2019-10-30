using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class TechSpecsModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(4,16)]
        public int RandomAccessMemory { get; set; }

        [Required]
        public float CpuSpeed { get; set; }

        [StringLength(70)]
        public string Graphics { get; set; }

        [EmailAddress]
        [StringLength(25)]
        public string Email { get; set; }

        [Required]
        [Url]
        public string WhereToBuy { get; set; }

        [Phone]
        public string SupportPhoneNumber { get; set; }
    }
}
