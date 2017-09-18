using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Assignment1.Models
{
    public class BasicSchool
    {
        public static List<Course> getAllCourses()
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();
            return db.courses.ToList();
        }

        public static Course getCourse(int? id)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();
            Course course = db.courses.Find(id);
            return course;
        }

        public static void addCourse(Course course)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();

            db.courses.Add(course);
            db.SaveChanges();
        }

        public static void editCourse(Course course)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();

            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void deleteCourse(Course course)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();

            db.courses.Attach(course);
            db.courses.Remove(course);
            db.SaveChanges();
        }

        public static List<Section> getAllSections()
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();
            return db.sections.ToList();
        }

        public static Section getSection(int? id)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();
            Section section = db.sections.Find(id);
            return section;
        }

        public static void addSection(Section section)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();

            db.sections.Add(section);
            db.SaveChanges();
        }

        public static void editSection(Section section)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();

            db.Entry(section).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void deleteSection(Section section)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();

            db.sections.Attach(section);
            db.sections.Remove(section);
            db.SaveChanges();
        }

        public static List<Section> courseSections(string courseNumber)
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();

            return db.sections.Where(x => x.courseNumber == courseNumber).ToList();
        }

        public static void Dispose()
        {
            BasicSchoolDbContext db = new BasicSchoolDbContext();
            db.Dispose();
        }
    }

    [Table("Course")] //tells entityframework from looking for wrong table
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Course Number")] 
        [RegularExpression("[a-zA-Z][a-zA-Z][0-9]*")]
        public string courseNumber { get; set; }

        [DisplayName("Course Name")]
        public string courseName { get; set; }

        [DisplayName("Credit Hours")]
        [Range(0, 4, ErrorMessage = "NO")]
        public int creditHours { get; set; }

        [DisplayName("Max Enrollment")]
        public int? maxEnrollment { get; set; }
    }

    [Table("Section")]
    public class Section
    {
        [Key]
        public int Id { get; set; }
        public int sectionId { get; set; }
        public int sectionNumber { get; set; }
        public string courseNumber { get; set; }
        public string sectionDays { get; set; }
        public DateTime sectionTime { get; set; }
    }

    public class BasicSchoolDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Section> sections { get; set; }
    }



}