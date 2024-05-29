using Libs;
using Model.Order;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderModel> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public OrderModel GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        public void CreateOrder(OrderModel order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(OrderModel order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
