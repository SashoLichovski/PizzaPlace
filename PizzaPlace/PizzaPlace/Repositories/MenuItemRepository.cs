using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly PizzaPlaceDbContext context;

        public MenuItemRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }
        public List<MenuItem> GetAll()
        {
            return context.MenuItems.ToList();
        }
    }
}
