using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModel
{
    public class OrderInfoView
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
    }
}
