using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class OrderDetails
    {
        public int Id { get; set; } 
        
        [Required]
        public int ProductId { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public double Qty { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double UnitPrice { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int DiscountPercenteg { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
