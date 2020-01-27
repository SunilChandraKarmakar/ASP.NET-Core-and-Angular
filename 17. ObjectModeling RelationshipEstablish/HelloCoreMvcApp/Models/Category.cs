using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }    

        public IEnumerable<Product> Products { get; set; }
    }
}
