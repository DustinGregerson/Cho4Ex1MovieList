using Microsoft.AspNetCore.Mvc;

namespace Cho4Ex1MovieList.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}