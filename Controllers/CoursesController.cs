using Microsoft.AspNetCore.Mvc;

namespace Mycourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("sono Index");
        }
        public IActionResult Detail(string id)
        {
            return Content($"sono detail, ho ricevuto l'id {id}");            
        }
    }
}