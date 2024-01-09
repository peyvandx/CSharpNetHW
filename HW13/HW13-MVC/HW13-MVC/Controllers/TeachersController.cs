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
                return View("Error With Login");
            }
            else
            {
                //success
                TempDB.OnlineTeacher = signedInTeacher;
                return RedirectToAction("Home");
            }
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
