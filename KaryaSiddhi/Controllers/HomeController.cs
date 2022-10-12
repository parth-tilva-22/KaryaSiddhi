using Microsoft.AspNetCore.Mvc;

namespace KaryaSiddhi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
