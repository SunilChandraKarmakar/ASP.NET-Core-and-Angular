using Models;
using Models.ViewModel;
using ProjectRepositorys.Base;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRepositorys
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        [Obsolete]
        public List<OrderInfoView> OrderInfoView()
        {
            return _coreDb.OrderInfoViews.ToList();   
        }

        [Obsolete]
        public ICollection<OrderViewModelSP> OrderViewModelSPs()
        {
            return _coreDb.OrderViewModelSPs();
        }
    }
}
