using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PizzaPlace.Models
{
    public class PizzaPlaceDbContext : IdentityDbContext
    {
        public PizzaPlaceDbContext(DbContextOptions<PizzaPlaceDbContext> options) : base(options)
        {

        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
