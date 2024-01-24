﻿using HW13_MVC.Models;
using HW13_MVC.TempDataBase;
using HW13_MVC.Utilities;

namespace HW13_MVC.Services
{
    public class StudentCourseUtilities
    {
        private DataAccess dataAccess = new DataAccess("Teachers.json", "Students.json", "Courses.json", "IdCounter.json");
        public void EnrollCourse(EnrollCourseDTO enrollCourseDTO)
        {
            var enrolledCourse = TempDB.Courses.FirstOrDefault(c => c.ID == enrollCourseDTO.CourseID);
            enrolledCourse.EnrolledStudents++;
            TempDB.OnlineStudent.SignedUpCourses.Add(enrolledCourse);

            dataAccess.SaveCourses();
            dataAccess.SaveOnlineStudent();
            dataAccess.SaveTheTeacherWhoOwnsThisCourse(enrollCourseDTO);
        }
    }
}
