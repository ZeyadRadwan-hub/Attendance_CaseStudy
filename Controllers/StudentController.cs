using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using New_Project_Atten.Models;
using New_Project_Atten.Repo.Interface;

namespace New_Project_Atten.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent Std;

        public StudentController (IStudent StuCont)
        {
            this.Std = StuCont;
        }

        // GET: StudentController
        public IActionResult Index()
        {
            var Students = Std.GetAll();
            return View(Students);
        }

        // GET: StudentController/Details/5
        public IActionResult Details(int id)
        {
            var OneStudent = Std.GetByID(id);
            if(OneStudent == null)
            {
                return NotFound();
            }
            return View(OneStudent);
        }

        // GET: StudentController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student Stu)
        {
            if(ModelState.IsValid)
            {
                Std.add(Stu);
                return RedirectToAction(nameof(Index));
            }
            return View(Stu);
        }

        // GET: StudentController/Edit/5
        public IActionResult Edit(int id)
        {
            var student = Std.GetByID(id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }
        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                Std.Update(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: StudentController/Delete/5
        public IActionResult Delete(int id)
        {
            var student = Std.GetByID(id);
            if(student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete2(int id)
        {
            Std.Delete(id); 
            return RedirectToAction(nameof(Index));
        }
    }
}
