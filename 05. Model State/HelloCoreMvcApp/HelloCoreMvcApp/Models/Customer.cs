﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMvcApp.Models
{
    public class Customer
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
