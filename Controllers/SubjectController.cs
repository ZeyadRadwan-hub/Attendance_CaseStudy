using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using New_Project_Atten.Models;
using New_Project_Atten.Repo.Interface;

namespace New_Project_Atten.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubject sub;
        public SubjectController (ISubject subject)
        {
            this.sub = subject;
        }

        // GET: SubjectController
        public IActionResult Index()
        {
            var subject = sub.GetAll();
            return View(subject);
        }

        // GET: SubjectController/Details/5
        public IActionResult Details(int id)
        {
            var subject = sub.GetByID(id);
            if(subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        // GET: SubjectController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subject subj)
        {
            if(ModelState.IsValid)
            {
               sub.add(subj);
               return RedirectToAction(nameof(Index));
            }
            return View(subj);
        }

        // GET: SubjectController/Edit/5
        public IActionResult Edit(int id)
        {
            var subject = sub.GetByID(id);
            if(subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Subject Sub)
        {

            if(ModelState.IsValid)
            {
                sub.Update(Sub);
                return RedirectToAction(nameof(Index));
            }
            return View(Sub);
        }

        // GET: SubjectController/Delete/5
        public IActionResult Delete(int id)
        {
            var Subject = sub.GetByID(id);
            if (Subject == null)
            {
                return NotFound();
            }
            return View(Subject);
        }

        // POST: SubjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete2(int id)
        {
            sub.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
