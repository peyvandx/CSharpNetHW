namespace HW13_MVC.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string NationalCode { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }

        public List<Course> SignedUpCourses { get; set; }
    }
}
