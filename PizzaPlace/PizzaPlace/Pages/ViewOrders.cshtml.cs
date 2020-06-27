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
    public class ViewOrdersModel : PageModel
    {
        private readonly IOrderService orderService;

        public ViewOrdersModel(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        public List<OrderViewModel> Orders { get; set; }
        public void OnGet()
        {
            Orders = new List<OrderViewModel>();
            var dbOrders = orderService.GetAll();
            Orders = dbOrders.Select(x => new OrderViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Address = x.Address,
                Phone = x.Phone,
                Message = x.Message,
                IsProcessed = x.IsProcessed,
                DateCreated = x.DateCreated,
                DateProcessed = x.DateProcessed
            }).ToList();
        }

        public IActionResult OnGetProcess(int id)
        {
            orderService.Process(id);
            return RedirectToPage("ViewOrders");
        }
    }
}