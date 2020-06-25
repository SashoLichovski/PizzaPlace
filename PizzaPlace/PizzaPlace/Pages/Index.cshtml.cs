using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IOfferService offerService;

        public IndexModel(IOfferService offerService)
        {
            this.offerService = offerService;
        }

        public List<SpecialOfferModel> SpecialOffers { get; set; }

        public void OnGet()
        {
            var dbOffers = offerService.GetAll();

            SpecialOffers = new List<SpecialOfferModel>();

            dbOffers.ForEach(x => SpecialOffers.Add(new SpecialOfferModel()
            {
                Title = x.Title,
                Description = x.Description,
                Price = x.Price,
                ValidTo = x.ValidTo
            }));
        }
    }
}
