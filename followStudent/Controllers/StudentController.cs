using followStudent.Models;
using Microsoft.AspNetCore.Mvc;

namespace followStudent.Controllers
{
    public class StudentController : Controller
    { 
        static List<StudentModel> students = new List<StudentModel>();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent(StudentModel student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Addliste(StudentModel student) 
        {
            return View(students);
        }
    }
}
