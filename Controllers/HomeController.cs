using Microsoft.AspNetCore.Mvc;

namespace SweetFactory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
