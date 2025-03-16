using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        // baseUrl/Movies/Index
        public string Index()
        {
            return "Hello From Index";
        }
        // baseUrl/Movies/GetMovie/Id
        [HttpGet]
        public void GetMovie(int? Id,string name)
        {

        }
    }
}
