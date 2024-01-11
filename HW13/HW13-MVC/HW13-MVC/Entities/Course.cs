namespace HW13_MVC.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        //public string TeacherFullName { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int Capacity { get; set; }
        public int EnrolledStudents { get; set; } = 0;
        public string StudentGrade { get; set; }
    }
}
