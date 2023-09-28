using Cho4Ex1MovieList.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cho4Ex1MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.OrderBy(m=>m.Name).ToList();
            return View(movies);
        }
    }
}