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
        #region ex1
        //[HttpGet]
        //public ContentResult GetMovie(int? Id,string name)
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = $"movie with Name={name} and </br> Id ={Id}";
        //    //result.ContentType = "text/html";
        //    //result.StatusCode = 700;
        //    //return result;
        //    return Content($"movie with Name={name} and Id ={Id}","text/html");
        //  //  return $"movie with Name={name} and Id ={Id}";
        //} 
        #endregion
        public IActionResult GetMovie(int? id, string name)
        {
            // Id 0 Bad Request 
            // Id < 10 - Not Found 
            // Id >= 10 -> Return Movie 
            if (id == 0)
                return BadRequest();
            else if (id < 10)
                return NotFound();
            else
                return Content(content: $"Movie With Name = {name} And Id = {id}", "text/html");
        }
        public IActionResult TestRedirectAction()
            {
            return RedirectToRoute("default", new { Controller = "Movies", Action = "GetMovie", Id = 10 });
            //  return RedirectToAction(nameof(GetMovie), "movies"// lazem tktbha anta n type of bayze btkon kda moviescontroller
            //                                                   , new { id = 10, name = "batoomasr" });
            //  return Redirect("https://www.instagram.com/youssefessam_74/");
        }
    }
}
