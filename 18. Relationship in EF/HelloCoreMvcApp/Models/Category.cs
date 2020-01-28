using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please give Code")]
        [StringLength(5, MinimumLength = 3)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please give Name")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }    

        public IEnumerable<Product> Products { get; set; }
    }
}
