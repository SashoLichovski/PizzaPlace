using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IMenuItemService itemService;

        public DetailsModel(IMenuItemService itemService)
        {
            this.itemService = itemService;
        }
        public MenuItemModel MenuItem { get; set; }
        public void OnGet(int id)
        {
            var dbItem = itemService.GetById(id);
            MenuItem = new MenuItemModel()
            {
                Id = dbItem.Id,
                Title = dbItem.Title,
                Description = dbItem.Description,
                ImageUrl = dbItem.ImageUrl,
                Price = dbItem.Price
            };
        }
    }
}