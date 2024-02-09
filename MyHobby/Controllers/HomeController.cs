using Microsoft.AspNetCore.Mvc;

namespace MyHobby.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Calculator()
        {
            return View("Calculator");
        }
    }
}
