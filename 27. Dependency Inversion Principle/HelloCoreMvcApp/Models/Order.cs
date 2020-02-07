using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public string OrderNo { get; set; }

        //public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
