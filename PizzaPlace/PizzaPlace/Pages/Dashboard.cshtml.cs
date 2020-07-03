using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPlace.Pages
{
    [Authorize]
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}