namespace HW13_MVC.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public string TeacherFullName { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public byte Capacity { get; set; }
        public string StudentGrade { get; set; }
        public decimal Price { get; set; }
    }
}
