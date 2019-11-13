using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class AddAccomplishmentBase
    {
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime DateOfAccomplishment { get; set; }
    }
}
