using PizzaPlace.Models;
using PizzaPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly PizzaPlaceDbContext context;

        public FeedbackRepository(PizzaPlaceDbContext context)
        {
            this.context = context;
        }

        public void Add(Feedback feedback)
        {
            context.Feedbacks.Add(feedback);
            context.SaveChanges();
        }
    }
}
