using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }
        public IEnumerable<Shop> Shops { get; set; }
        public IEnumerable<OrderDetails> OrderDetails { get; set; }
    }
}
