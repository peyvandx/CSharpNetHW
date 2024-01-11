using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.TempDataBase;

namespace HW13_MVC.Services
{
    public class TeacherCourseUtilities
    {
        public List<Student> ShowEnrolledStudents(int courseId)
        {
            return TempDB.Students.Where(s => s.SignedUpCourses.Any(c => c.ID == courseId)).ToList();
        }

        public void Grading(List<GradingStudentsDTO> gradingStudentsDTO)
        {
            
        }
    }
}
