using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.TempDataBase;
using Microsoft.AspNetCore.Mvc;

namespace HW13_MVC.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.SigninDTO = new SigninDTO();
            return View();
        }

        [HttpPost]
        public IActionResult Signup([FromForm] StudentDTO studentDTO)
        {
            Student newStudent = new Student();
            newStudent.ID = TempDB.IdCounter++;
            newStudent.FirstName = studentDTO.FirstName;
            newStudent.LastName = studentDTO.LastName;
            newStudent.Email = studentDTO.Email;
            newStudent.Password = studentDTO.Password;
            newStudent.Address = studentDTO.Address;
            newStudent.Age = studentDTO.Age;
            newStudent.NationalCode = studentDTO.NationalCode;
            newStudent.PhoneNumber = studentDTO.PhoneNumber;
            newStudent.Gender = studentDTO.Gender;

            TempDB.Students.Add(newStudent);

            return View();
        }

        [HttpPost]
        public IActionResult Singin([FromForm] StudentDTO studentDTO)
        {
            var signedInStudent = TempDB.Students.FirstOrDefault(s => s.Email == studentDTO.Email && s.Password == studentDTO.Password);
            if (signedInStudent == null)
            {
                //failed to signin, show error
            }
            else
            {
                //success
                TempDB.OnlineStudent = signedInStudent;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
