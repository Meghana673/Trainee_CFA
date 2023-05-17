using Microsoft.AspNetCore.Mvc;
using TE_CFA.Models;

namespace TE_CFA.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int studentId)
        {
            ViewData["Title"] = "Student Details Page";
           
            ViewData["Header"] = "Student Details";
         
            //ViewBag.Header = "Student Details";
            StudentsLayer studentBL = new StudentsLayer();
            Student studentDetail = studentBL.GetById(studentId);
            return View(studentDetail);
        }
    }
}
