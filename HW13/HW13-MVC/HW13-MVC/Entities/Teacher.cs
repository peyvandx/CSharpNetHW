namespace HW13_MVC.Entities
{
    public class Teacher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NationalCode { get; set; }
        public string Age { get; set; }
        public string Skill { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Course>? Courses { get; set; } = new List<Course>();
    }
}
