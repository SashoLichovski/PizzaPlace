using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly PizzaPlaceDbContext context;

        public OfferRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }
        public List<SpecialOffer> GetAll()
        {
            return context.SpecialOffers.ToList();
        }
    }
}
