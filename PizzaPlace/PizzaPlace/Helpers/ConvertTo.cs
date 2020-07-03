using PizzaPlace.Models;
using PizzaPlace.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Helpers
{
    public static class ConvertTo
    {
        internal static OrderViewModel OrderViewModel(Order x)
        {
            return new OrderViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Address = x.Address,
                Phone = x.Phone,
                Message = x.Message,
                IsProcessed = x.IsProcessed,
                DateCreated = x.DateCreated,
                DateProcessed = x.DateProcessed,
                IsDelivered = x.IsDelivered,
                DateDelivered = x.DateDelivered
            };
        }
    }
}
