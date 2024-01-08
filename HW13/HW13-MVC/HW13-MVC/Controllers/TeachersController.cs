using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.TempDataBase;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HW13_MVC.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup([FromForm] TeacherDTO teacherDTO)
        {
            Teacher newTeacher = new Teacher();
            newTeacher.ID = TempDB.IdCounter++;
            newTeacher.FirstName = teacherDTO.FirstName;
            newTeacher.LastName = teacherDTO.LastName;
            newTeacher.Email = teacherDTO.Email;
            newTeacher.Password = teacherDTO.Password;
            newTeacher.Address = teacherDTO.Address;
            newTeacher.Age = teacherDTO.Age;
            newTeacher.Skill = teacherDTO.Skill;
            newTeacher.NationalCode = teacherDTO.NationalCode;
            newTeacher.PhoneNumber = teacherDTO.PhoneNumber;
            newTeacher.Gender = teacherDTO.Gender;

            TempDB.Teachers.Add(newTeacher);

            return View();
        }

        [HttpPost]
        public IActionResult Singin([FromForm] TeacherDTO teacherDTO)
        {
            var signedInTeacher = TempDB.Teachers.FirstOrDefault(t => t.Email == teacherDTO.Email && t.Password == teacherDTO.Password);
            if (signedInTeacher == null)
            {
                //failed to signin, show error
            } else
            {
                //success
                TempDB.OnlineTeacher = signedInTeacher;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
