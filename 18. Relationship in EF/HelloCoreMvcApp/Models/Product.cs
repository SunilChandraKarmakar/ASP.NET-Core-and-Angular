using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please give Product Name")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Select Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please give Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please give Discription")]
        [StringLength(50, MinimumLength = 3)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }         

        public Category Category { get; set; }
        //public IEnumerable<Shop> Shops { get; set; }
        //public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
