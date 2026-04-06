using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using New_Project_Atten.Models;
using New_Project_Atten.Repo.Interface;

namespace New_Project_Atten.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IAttendance att;
        public AttendanceController(IAttendance Atten)
        {
            this.att = Atten;
        }

        // GET: SubjectController
        public IActionResult Index()
        {
            var Attend = att.GetAll();
            return View(Attend);
        }

        // GET: SubjectController/Details/5
        public IActionResult Details(int id)
        {
            var Attend = att.GetByID(id);
            if (Attend == null)
            {
                return NotFound();
            }
            return View(Attend);
        }

        // GET: SubjectController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Attendance Attend)
        {
            if (ModelState.IsValid)
            {
                att.add(Attend);
                return RedirectToAction(nameof(Index));
            }
            return View(Attend);
        }

        // GET: SubjectController/Edit/5
        public IActionResult Edit(int id)
        {
            var Attend = att.GetByID(id);
            if (Attend == null)
            {
                return NotFound();
            }
            return View(Attend);
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Attendance Attend)
        {

            if (ModelState.IsValid)
            {
                att.Update(Attend);
                return RedirectToAction(nameof(Index));
            }
            return View(att);
        }

        // GET: SubjectController/Delete/5
        public IActionResult Delete(int id)
        {
            var Attend = att.GetByID(id);
            if (Attend == null)
            {
                return NotFound();
            }
            return View(Attend);
        }

        // POST: SubjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete2(int id)
        {
            att.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
