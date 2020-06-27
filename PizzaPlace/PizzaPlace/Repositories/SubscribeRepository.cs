using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public class SubscribeRepository : ISubscribeRepository
    {
        private readonly PizzaPlaceDbContext context;

        public SubscribeRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Subscribe subscribe)
        {
            context.Subscribes.Add(subscribe);
            context.SaveChanges();
        }

        public List<Subscribe> GetAll()
        {
            return context.Subscribes.ToList();
        }
    }
}
