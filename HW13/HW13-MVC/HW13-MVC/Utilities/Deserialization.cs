using HW13_MVC.Entities;
using Newtonsoft.Json;

namespace HW13_MVC.Utilities
{
    public class Deserialization
    {
        public List<Teacher> DeserializeTeachers(string teachers)
        {
            return JsonConvert.DeserializeObject<List<Teacher>>(teachers);
        }

        public List<Student> DeserializeStudents(string students)
        {
            return JsonConvert.DeserializeObject<List<Student>>(students);
        }

        public List<Course> DeserializeCourses(string courses)
        {
            return JsonConvert.DeserializeObject<List<Course>>(courses);
        }

        public int DeserializeIdCounter(string idCounter)
        {
            return JsonConvert.DeserializeObject<int>(idCounter);
        }
    }
}
