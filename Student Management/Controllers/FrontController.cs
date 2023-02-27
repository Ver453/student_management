using Microsoft.AspNetCore.Mvc;

namespace Student_Management.Controllers
{
    public class FrontController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
