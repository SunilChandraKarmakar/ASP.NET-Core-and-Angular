using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyIdentity.Models
{
    public class AppUser : IdentityUser
    {
        public string Location { get; set; }
        public string RegNo { get; set; }
    }
}
