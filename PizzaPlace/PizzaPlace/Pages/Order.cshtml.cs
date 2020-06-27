using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.Models;
using PizzaPlace.Services.Interfaces;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService orderService;
        private readonly ISubscribeService subscribeService;

        public OrderModel(IOrderService orderService, ISubscribeService subscribeService)
        {
            this.orderService = orderService;
            this.subscribeService = subscribeService;
        }
        [BindProperty]
        public OrderViewModel Order { get; set; }
        public string ErrorMessage { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var order = new Order()
                {
                    Name = Order.Name,
                    Surname = Order.Surname,
                    Address = Order.Address,
                    Phone = Order.Phone,
                    Message = Order.Message
                };
                orderService.Add(order);

                return RedirectToPage("Success", "Order");
            }
            return Page();
        }

        public IActionResult OnPostSubscribe(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ErrorMessage = "Please enter email adress";
                return Page();
            }

            bool isValid = subscribeService.Validate(email);
            if (isValid)
            {
                subscribeService.Add(email);
                return RedirectToPage("Success", "Subscribe");
            }

            ErrorMessage = "This email adress already subscribed";
            return Page();
        }
    }
}