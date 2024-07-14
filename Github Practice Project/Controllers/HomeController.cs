using Microsoft.AspNetCore.Mvc;

namespace Github_Practice_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
