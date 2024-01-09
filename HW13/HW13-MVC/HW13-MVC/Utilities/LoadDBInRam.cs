using HW13_MVC.TempDataBase;

namespace HW13_MVC.Utilities
{
    public class LoadDBInRam
    {
        private DataAccess dataAccess = new DataAccess("Teachers.json", "Students.json", "Courses.json", "IdCounter.json");

        public void LoadDB()
        {
            TempDB.Teachers = dataAccess.ReadTeachers();
            TempDB.Students = dataAccess.ReadStudents();
            //TempDB.Courses = dataAccess.ReadCourses();
            TempDB.IdCounter = dataAccess.ReadIdCounter();
        }
    }
}
