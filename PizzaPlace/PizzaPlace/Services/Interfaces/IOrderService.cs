using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services.Interfaces
{
    public interface IOrderService
    {
        void Add(Order order);
        List<Order> GetAll();
        void Process(int id);
        List<Order> GetByStatus(bool IsProcessed, bool isDelivered);
        void Deliver(int id);
    }
}
