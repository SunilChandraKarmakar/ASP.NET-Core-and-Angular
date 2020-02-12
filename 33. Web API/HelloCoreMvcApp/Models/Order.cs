using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string OrderNo { get; set; }

        public Customer Customer { get; set; }
        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
