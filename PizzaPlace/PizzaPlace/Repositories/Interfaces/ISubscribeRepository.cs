using PizzaPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories.Interfaces
{
    public interface ISubscribeRepository
    {
        void Add(Subscribe subscribe);
        List<Subscribe> GetAll();
    }
}
