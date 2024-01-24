using HW13_MVC.Entities;
using HW13_MVC.Models;
using HW13_MVC.TempDataBase;
using HW13_MVC.Utilities;

namespace HW13_MVC.Services
{
    public class TeacherCourseUtilities
    {
        private DataAccess dataAccess = new DataAccess("Teachers.json", "Students.json", "Courses.json", "IdCounter.json");

        public List<Student> ShowEnrolledStudents(int courseId)
        {
            return TempDB.Students.Where(s => s.SignedUpCourses.Any(c => c.ID == courseId)).ToList();
        }

        public void Grading(GradingStudentsDTO gradingStudentsDTO)
        {
            var student = TempDB.Students.FirstOrDefault(s => s.ID == gradingStudentsDTO.StudentID);
            if (student != null)
            {
                var studentGradedCourse = student.SignedUpCourses.FirstOrDefault(c => c.ID == gradingStudentsDTO.CourseID);
                studentGradedCourse.StudentGrade = gradingStudentsDTO.Grade;
                dataAccess.SaveStudents();
            }

        }
    }
}
