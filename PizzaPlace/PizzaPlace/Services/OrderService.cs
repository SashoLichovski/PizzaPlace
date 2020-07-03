using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void Add(Order order)
        {
            orderRepository.Add(order);
        }

        public void Deliver(int id)
        {
            var order = orderRepository.GetById(id);
            order.IsDelivered = true;
            order.DateDelivered = DateTime.Now;
            orderRepository.Update(order);
        }

        public List<Order> GetAll()
        {
            return orderRepository.GetAll();
        }

        public List<Order> GetByStatus(bool IsProcessed, bool isDelivered)
        {
            return orderRepository.GetByStatus(IsProcessed, isDelivered);
        }

        public void Process(int id)
        {
            var order = orderRepository.GetById(id);
            order.IsProcessed = true;
            order.DateProcessed = DateTime.Now;
            orderRepository.Update(order);
        }
    }
}
