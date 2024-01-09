using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.Services;
using HW13_MVC.TempDataBase;
using Microsoft.AspNetCore.Mvc;

namespace HW13_MVC.Controllers
{
    public class StudentsController : Controller
    {
        private StudentCRUD studentCRUD = new StudentCRUD();
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
                return RedirectToAction("Home");
            }
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
