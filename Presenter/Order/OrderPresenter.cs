using Model.Order;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Order
{
    public class OrderPresenter
    {
        private readonly IOrderRepository _repository;

        public OrderPresenter(IOrderRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<OrderModel> GetAllOrders()
        {
            return _repository.GetAllOrders();
        }

        public OrderModel GetOrderById(int id)
        {
            return _repository.GetOrderById(id);
        }

        public void CreateOrder(OrderModel order)
        {
            _repository.CreateOrder(order);
        }

        public void UpdateOrder(OrderModel order)
        {
            _repository.UpdateOrder(order);
        }

        public void DeleteOrder(int id)
        {
            _repository.DeleteOrder(id);
        }
    }
}
