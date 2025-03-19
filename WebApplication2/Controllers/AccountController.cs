using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AccountController : Controller
    {
        //BaseURL/Account/SignIn
        public IActionResult SignIn()
        {
            return View();
        }
        //BaseURL/Account/Register
        public IActionResult Register()
        {
            return View();
        }

    }
}
