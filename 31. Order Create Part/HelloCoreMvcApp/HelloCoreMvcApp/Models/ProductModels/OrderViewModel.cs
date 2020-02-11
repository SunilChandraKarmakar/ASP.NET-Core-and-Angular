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
       
        public IEnumerable<OrderDetails> OrderDetails { get; set; } 
        public List<SelectListItem> CustomerList { get; set; }
        public List<SelectListItem> ProductList { get; set; }
    }
}
