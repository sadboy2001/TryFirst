using Microsoft.AspNetCore.Mvc;

namespace TryFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
