using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono l'index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono il details, mi p stato passato l'id {id}");
        }
    }
}