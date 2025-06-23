using Microsoft.AspNetCore.Mvc;

namespace EventEase2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
