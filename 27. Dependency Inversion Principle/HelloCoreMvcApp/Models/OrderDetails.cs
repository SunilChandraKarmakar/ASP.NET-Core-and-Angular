using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public Order Order { get; set; }

        public Product Product { get; set; }
        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public int DiscountPercenteg { get; set; }
    }
}
