using Student_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Student_Management.Data;

namespace Student_Management.Controllers
{
    public class FacultyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FacultyController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FacultyModel faculty)
        {
            if (faculty == null)
            {
                throw new ArgumentNullException();
            }
            if (ModelState.IsValid)
            {
                _context.faculties.Add(faculty);
                await _context.SaveChangesAsync();
                TempData["ResultOk"] = "Faculty added successfully!!";
                return RedirectToAction("Create");
            }
            return View(faculty);
        }
    }
}
