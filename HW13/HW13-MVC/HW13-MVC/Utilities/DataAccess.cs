using HW13_MVC.Entities;
using HW13_MVC.TempDataBase;

namespace HW13_MVC.Utilities
{
    public class DataAccess
    {
        private readonly string _teachersPath;
        private readonly string _studentsPath;
        private readonly string _coursesPath;
        private Serialization serialization = new Serialization();
        private Deserialization deserialization = new Deserialization();
        public DataAccess(string teachersPath, string studentsPath, string coursesPath)
        {
            this._teachersPath = teachersPath;
            this._studentsPath = studentsPath;
            this._coursesPath = coursesPath;
        }
        public void SaveTeachers()
        {
            var teachersJson = serialization.SerializeTeachersToJson(TempDB.Teachers);
            File.WriteAllText(_teachersPath, teachersJson);
        }
        public void SaveStudents()
        {
            var studentsJson = serialization.SerializeStudentsToJson(TempDB.Students);
            File.WriteAllText(_studentsPath, studentsJson);
        }

        public void SaveCourses()
        {
            var coursesJson = serialization.SerializeCoursesToJson(TempDB.Courses);
            File.WriteAllText(_coursesPath, coursesJson);
        }

        public List<Teacher> ReadTeachers()
        {
            var fileData = File.ReadAllText(_teachersPath);
            return deserialization.DeserializeTeachers(fileData);
        }

        public List<Student> ReadStudents()
        {
            var fileData = File.ReadAllText(_studentsPath);
            return deserialization.DeserializeStudents(fileData);
        }

        public List<Course> ReadCourses()
        {
            var fileData = File.ReadAllText(_coursesPath);
            return deserialization.DeserializeCourses(fileData);
        }
    }
}
