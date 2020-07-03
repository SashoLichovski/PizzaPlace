using System.Collections.Generic;
using System.Linq;
using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;

namespace PizzaPlace.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PizzaPlaceDbContext context;

        public OrderRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return context.Orders.OrderByDescending(x => x.DateCreated).ToList();
        }

        public Order GetById(int id)
        {
            return context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public List<Order> GetByStatus(bool isProcessed, bool isDelivered)
        {
            return context.Orders
                .OrderByDescending(x => x.DateCreated)
                .Where(x => x.IsProcessed == isProcessed && x.IsDelivered == isDelivered)
                .ToList();
        }

        public void Update(Order order)
        {
            context.Orders.Update(order);
            context.SaveChanges();
        }
    }
}
