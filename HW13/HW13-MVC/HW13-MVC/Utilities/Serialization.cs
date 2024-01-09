using HW13_MVC.Entities;
using Newtonsoft.Json;

namespace HW13_MVC.Utilities
{
    public class Serialization
    {
        public string SerializeTeachersToJson(List<Teacher> teachers)
        {
            return JsonConvert.SerializeObject(teachers);
        }

        public string SerializeStudentsToJson(List<Student> students)
        {
            return JsonConvert.SerializeObject(students);
        }

        public string SerializeCoursesToJson(List<Course> courses)
        {
            return JsonConvert.SerializeObject(courses);
        }
    }
}
