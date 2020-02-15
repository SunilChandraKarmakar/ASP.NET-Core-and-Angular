using Business_Logic_Layer.BLL;
using Business_Logic_Layer.Contracts;
using Models;
using Models.ViewModel;
using ProjectRepositorys.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer
{
    public class OrderManager : Manager<Order>, IOrderManager
    {
        private readonly IOrderRepository _iOrderRepository;
        public OrderManager(IOrderRepository iOrderRepository) : base(iOrderRepository)
        {
            _iOrderRepository = iOrderRepository;
        }

        public List<OrderInfoView> OrderInfoView()
        {
            return _iOrderRepository.OrderInfoView();
        }

        public ICollection<OrderViewModelSP> OrderViewModelSPs()
        {
            return _iOrderRepository.OrderViewModelSPs();
        }
    }
}
