namespace HW12.Models
{
    public class SignupModel
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public GenderType Gender { get; set; }
    }

    public enum GenderType { Male = 0, Female = 1 }
}
