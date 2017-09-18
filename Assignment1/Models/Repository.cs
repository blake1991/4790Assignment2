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

        public static Section getSection(int? id)
        {
            Section section = BasicSchool.getSection(id);
            return section;
        }

        public static List<Section> getAllSections()
        {
            return BasicSchool.getAllSections();
        }

        public static void addSection(Section section)
        {
            BasicSchool.addSection(section);
        }

        public static void editSection(Section section)
        {
            BasicSchool.editSection(section);
        }

        public static void deleteSection(Section section)
        {
            BasicSchool.deleteSection(section);
        }

        public static List<Section> courseSections(string courseNumber)
        {
            return BasicSchool.courseSections(courseNumber);
        }

        public static void Dispose()
        {
            BasicSchool.Dispose();
        }
    }


}