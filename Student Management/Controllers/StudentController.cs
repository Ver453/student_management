using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Management.Data;
using Student_Management.Models;

namespace Student_Management.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: StudentController
        public IActionResult Index()
        {
            IEnumerable<StudentModel> stdlist = _context.students;
            return View(stdlist);
        }

        // GET: StudentController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: StudentController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: StudentController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: StudentController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: StudentController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: StudentController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: StudentController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
