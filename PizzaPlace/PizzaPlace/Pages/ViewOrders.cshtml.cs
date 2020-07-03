using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Helpers;
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
            ViewData["Title"] = "All orders";
            Orders = new List<OrderViewModel>();
            var dbOrders = orderService.GetAll();
            Orders = dbOrders.Select(x => ConvertTo.OrderViewModel(x)).ToList();
        }

        public IActionResult OnGetProcess(int id)
        {
            orderService.Process(id);
            return RedirectToPage("ViewOrders", "NotProcessed");
        }

        public void OnGetNotProcessed()
        {
            ViewData["Title"] = "Orders not processed";
            var dbOrders = orderService.GetByStatus(false, false);
            Orders = dbOrders.Select(x => ConvertTo.OrderViewModel(x)).ToList();
        }

        public void OnGetProcessed()
        {
            ViewData["Title"] = "Orders ready for delivery";
            var dbOrders = orderService.GetByStatus(true, false);
            Orders = dbOrders.Select(x => ConvertTo.OrderViewModel(x)).ToList();
        }

        public IActionResult OnGetDeliver(int id)
        {
            orderService.Deliver(id);
            return RedirectToPage("ViewOrders", "Processed");
        }

        public void OnGetDone()
        {
            ViewData["Title"] = "Complete orders";
            var dbOrders = orderService.GetByStatus(true, true);
            Orders = dbOrders.Select(x => ConvertTo.OrderViewModel(x)).ToList();
        }
    }
}