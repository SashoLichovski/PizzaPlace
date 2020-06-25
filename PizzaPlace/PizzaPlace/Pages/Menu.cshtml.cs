using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class MenuModel : PageModel
    {
        private readonly IMenuItemService service;

        public MenuModel(IMenuItemService service)
        {
            this.service = service;
        }
        public List<MenuItemModel> MenuItems { get; set; }
        public void OnGet()
        {
            MenuItems = new List<MenuItemModel>();

            var dbList = service.GetAll();

            dbList.ForEach(x => MenuItems.Add( new MenuItemModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                DateCreated = x.DateCreated
            }));
            
        }
    }
}