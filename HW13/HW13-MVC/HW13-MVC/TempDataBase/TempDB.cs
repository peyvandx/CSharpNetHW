using HW13_MVC.Entities;

namespace HW13_MVC.TempDataBase
{
    public static class TempDB
    {
        public static List<Teacher> Teachers { get; set; } = new List<Teacher> ();
        public static List<Student> Students { get; set; } = new List<Student>();
        public static List<Course> Courses { get; set; } = new List<Course>();
        public static int IdCounter { get; set; } = 1;
        public static Student? OnlineStudent { get; set; }
        public static Teacher? OnlineTeacher { get; set; }
    }
}
