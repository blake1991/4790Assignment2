using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Repository
    {
        public static Course getCourse(int? id)
        {
            Course course = BasicSchool.getCourse(id);
            return course;
        }

        public static List<Course> getAllCourses()
        {
            return BasicSchool.getAllCourses();
        }

        public static void addCourse(Course course)
        {
            BasicSchool.addCourse(course);
        }

        public static void editCourse(Course course)
        {
            BasicSchool.editCourse(course);
        }

        public static void deleteCourse(Course course)
        {
            BasicSchool.deleteCourse(course);
        }

        public static void Dispose()
        {
            BasicSchool.Dispose();
        }
    }


}