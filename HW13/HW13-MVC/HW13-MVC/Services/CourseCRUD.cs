using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.TempDataBase;
using HW13_MVC.Utilities;

namespace HW13_MVC.Services
{
    public class CourseCRUD
    {
        private DataAccess dataAccess = new DataAccess("Teachers.json", "Students.json", "Courses.json", "IdCounter.json");
        public void Create(CourseDTO courseDTO)
        {
            Course newCourse = new Course();
            newCourse.ID = TempDB.IdCounter++;
            newCourse.Title = courseDTO.Title;
            newCourse.Description = courseDTO.Description;
            newCourse.Duration = courseDTO.Duration;
            newCourse.Capacity = courseDTO.Capacity;

            TempDB.Courses.Add(newCourse);
            TempDB.OnlineTeacher.Courses.Add(newCourse);
            dataAccess.SaveCourses();
            dataAccess.SaveIdCounter();
            dataAccess.SaveTeachers();
        }
    }
}
