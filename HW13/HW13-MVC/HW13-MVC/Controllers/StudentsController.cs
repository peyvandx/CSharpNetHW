using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.Services;
using HW13_MVC.TempDataBase;
using HW13_MVC.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace HW13_MVC.Controllers
{
    public class StudentsController : Controller
    {
        private StudentCRUD studentCRUD = new StudentCRUD();
        private StudentCourseUtilities studentCourseUtilities = new StudentCourseUtilities();
        private LoadDBInRam loadDBInRam = new LoadDBInRam();
        public IActionResult Index()
        {
            //ViewBag.SigninDTO = new SigninDTO();
            return View();
        }

        [HttpPost]
        public IActionResult Signup([FromForm] StudentDTO studentDTO)
        {
            studentCRUD.Create(studentDTO);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Singin([FromForm] StudentDTO studentDTO)
        {
            var signedInStudent = TempDB.Students.FirstOrDefault(s => s.Email == studentDTO.Email && s.Password == studentDTO.Password);
            if (signedInStudent == null)
            {
                //failed to signin, show error
                return View("Error With Login");
            }
            else
            {
                //success
                TempDB.OnlineStudent = signedInStudent;
                //ViewBag.OnlineStudentFName = TempDB.OnlineStudent.FirstName;
                //ViewBag.OnlineStudentLName = TempDB.OnlineStudent.LastName;
                return RedirectToAction("Home");
            }
        }

        public IActionResult Home()
        {
            loadDBInRam.LoadDB();
            ViewBag.OnlineStudent = TempDB.OnlineStudent;
            ViewBag.Courses = TempDB.Courses;
            return View();
        }

        public IActionResult EnrollCourse(EnrollCourseDTO enrollCourseDTO)
        {
            studentCourseUtilities.EnrollCourse(enrollCourseDTO);
            return RedirectToAction("Home");
        }

        public IActionResult Logout()
        {
            TempDB.OnlineStudent = new Student();
            return RedirectToAction("Index");
        }
    }
}
