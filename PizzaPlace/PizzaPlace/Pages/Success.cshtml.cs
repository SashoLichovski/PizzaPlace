using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPlace.Pages
{
    public class SuccessModel : PageModel
    {
        public string Message { get; set; }
        public void OnGetSubscribe()
        {
            Message = "Thank you for subscribing !!!";
        }

        public void OnGetOrder()
        {
            Message = "Thank you for ordering !!!";
        }
    }
}