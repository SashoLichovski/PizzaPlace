using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using PizzaPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Services
{
    public class SubscribeService : ISubscribeService
    {
        private readonly ISubscribeRepository subscribeRepository;

        public SubscribeService(ISubscribeRepository subscribeRepository)
        {
            this.subscribeRepository = subscribeRepository;
        }

        public void Add(string email)
        {
            var subscribe = new Subscribe()
            {
                EmailAdress = email
            };
            subscribeRepository.Add(subscribe);
        }

        public bool Validate(string email)
        {
            var all = subscribeRepository.GetAll();
            var subscribe = all.FirstOrDefault(x => x.EmailAdress == email);
            if (subscribe == null)
            {
                return true;
            }
            return false;
        }
    }
}
