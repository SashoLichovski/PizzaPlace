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
    public class FeedbackModel : PageModel
    {
        private readonly IFeedbackService feedbackService;

        public FeedbackModel(IFeedbackService feedbackService)
        {
            this.feedbackService = feedbackService;
        }

        [BindProperty]
        public FeedbackViewModel Feedback { get; set; }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var feedback = new Feedback()
                {
                    EmailAdress = Feedback.EmailAdress,
                    Name = Feedback.Name,
                    Surname = Feedback.Surname,
                    Message = Feedback.Message
                };
                feedbackService.Add(feedback);
                return RedirectToPage("Success", "Subscribe");
            }
            return Page();
        }
    }
}