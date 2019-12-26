using Microsoft.AspNetCore.Mvc;

namespace Mycourse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("sono la index della base");
        }
    }
}