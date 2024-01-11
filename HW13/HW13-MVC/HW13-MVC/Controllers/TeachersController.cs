using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.Services;
using HW13_MVC.TempDataBase;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HW13_MVC.Controllers
{
    public class TeachersController : Controller
    {
        private TeacherCRUD teacherCRUD = new TeacherCRUD();
        private CourseCRUD courseCRUD = new CourseCRUD();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup([FromForm] TeacherDTO teacherDTO)
        {
            teacherCRUD.Create(teacherDTO);
            //show a message
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Singin([FromForm] TeacherDTO teacherDTO)
        {
            var signedInTeacher = TempDB.Teachers.FirstOrDefault(t => t.Email == teacherDTO.Email && t.Password == teacherDTO.Password);
            if (signedInTeacher == null)
            {
                //failed to signin, show error
                //search in TempDB.Students. if exist, say you're student and redirect to student controller-index action
                return View("Error With Login");
            }
            else
            {
                //success
                TempDB.OnlineTeacher = signedInTeacher;
                return RedirectToAction("Home", signedInTeacher);
            }
        }

        public IActionResult Home()
        {
            ViewBag.OnlineTeacher = TempDB.OnlineTeacher;
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourse(CourseDTO courseDTO)
        {
            courseCRUD.Create(courseDTO);
            return RedirectToAction("Home");
        }
    }
}
