using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.TempDataBase;
using HW13_MVC.Utilities;

namespace HW13_MVC.Services
{
    public class TeacherCRUD
    {
        private DataAccess dataAccess = new DataAccess("Teachers.json", "Students.json", "Courses.json", "IdCounter.json");
        public void Create(TeacherDTO teacherDTO)
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
            dataAccess.SaveTeachers();
            dataAccess.SaveIdCounter();
        }
    }
}
