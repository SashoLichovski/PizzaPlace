using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaPlace.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository repository;

        public OfferService(IOfferRepository repository)
        {
            this.repository = repository;
        }

        public List<SpecialOffer> GetAll()
        {
            return repository.GetAll();
        }
    }
}
