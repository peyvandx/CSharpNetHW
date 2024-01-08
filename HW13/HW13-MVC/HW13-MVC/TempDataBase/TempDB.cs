using HW13_MVC.Entities;

namespace HW13_MVC.TempDataBase
{
    public static class TempDB
    {
        public static List<Teacher> Teachers { get; set; }
        public static List<Student> Students { get; set; }
        public static List<Course> Courses { get; set; }
        public static int IdCounter { get; set; } = 1;
        public static Student? OnlineStudent { get; set; }
        public static Teacher? OnlineTeacher { get; set; }
    }
}
