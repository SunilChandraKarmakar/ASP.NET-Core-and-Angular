using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please give Customer Name")]
        [StringLength(30, MinimumLength = 5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please give Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please give Phone No")]
        [StringLength(14, MinimumLength = 11)]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
