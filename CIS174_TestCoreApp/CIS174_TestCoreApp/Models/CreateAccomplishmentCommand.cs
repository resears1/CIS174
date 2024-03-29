﻿using CIS174_TestCoreApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class CreateAccomplishmentCommand
    {

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfAccomplishment { get; set; }

        public Accomplishment ToAccomplishment() {
            return new Accomplishment
            {
                Name = Name,
                DateOfAccomplishment = DateOfAccomplishment,
            };
        }
    }
}
