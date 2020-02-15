using Models;
using Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.Contracts
{
    public interface IOrderManager : IManager<Order>
    {
        List<OrderInfoView> OrderInfoView();
        ICollection<OrderViewModelSP> OrderViewModelSPs();
    }
}
