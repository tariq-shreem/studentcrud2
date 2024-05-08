using Microsoft.AspNetCore.Mvc;
using Session3.Data;
using Session3.Models;

namespace Session3.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var students = context.Students.ToList();
            return View("Index", students);
        }

        public IActionResult Details(int id)
        {
            var student = context.Students.Find(id);
            return View("Details", student);
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult Store(Student student)
        {

            context.Students.Add(student);
            context.SaveChanges();
       
            return RedirectToAction("Index");
        }
       

        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);

            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
