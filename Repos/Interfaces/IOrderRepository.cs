using Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<OrderModel> GetAllOrders();
        OrderModel GetOrderById(int id);
        void CreateOrder(OrderModel order);
        void UpdateOrder(OrderModel order);
        void DeleteOrder(int id);
    }
}
