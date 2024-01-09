using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.TempDataBase;
using HW13_MVC.Utilities;

namespace HW13_MVC.Services
{
    public class StudentCRUD
    {
        private DataAccess dataAccess = new DataAccess("Teachers.json", "Students.json", "Courses.json", "IdCounter.json");
        public void Create(StudentDTO studentDTO)
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
            dataAccess.SaveStudents();
            dataAccess.SaveIdCounter();
        }
    }
}
