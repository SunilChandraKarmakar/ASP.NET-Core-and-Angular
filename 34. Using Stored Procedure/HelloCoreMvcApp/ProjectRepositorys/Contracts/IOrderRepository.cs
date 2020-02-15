using Models;
using Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRepositorys.Contracts
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<OrderInfoView> OrderInfoView();    
        ICollection<OrderViewModelSP> OrderViewModelSPs(string cName, string oNo);
    }
}
