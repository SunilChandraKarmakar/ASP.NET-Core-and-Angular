using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCoreMvcApp.Models.ProductModels
{
    public class OrderViewModel
    {
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
        public Customer Customer { get; set; }    
        public int ProductId { get; set; }
        public double Qty { get; set; }
        public double UnitPrice { get; set; }
        public int DiscountPercenteg { get; set; }
        public Order Order { get; set; }

        public List<SelectListItem> CustomerList { get; set; }
        public List<SelectListItem> ProductList { get; set; }
        public IEnumerable<OrderDetails> OrderDetails { get; set; }
        
    }
}
