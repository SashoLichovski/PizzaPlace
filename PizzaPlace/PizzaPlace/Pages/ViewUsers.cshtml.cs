using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaPlace.ViewModels;

namespace PizzaPlace.Pages
{
    public class ViewUsersModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;

        public ViewUsersModel(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public List<UserModel> Users { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "All users";

            var dbUsers = userManager.Users.ToList();

            Users = dbUsers.Select(x => new UserModel()
            {
                Id = x.Id,
                Email = x.Email
            }).ToList();
        }
    }
}