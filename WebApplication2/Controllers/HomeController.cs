using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        //BaseURL/Home/Index
        public IActionResult Index()
        {
         ///   return View("Hamada",new Movie()); // return view with a specific name to bind view with model data
         ///      return View("Hamada"); // return view with a specific name
         ///      return View(new Movie()); // take model to bind view with model data
          return View(); // return view with same name of action
        }
        //BaseURL/Home/Praivcy
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
