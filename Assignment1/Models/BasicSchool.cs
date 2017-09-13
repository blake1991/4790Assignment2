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
    }

    [Table("Course")] //tells entityframework from looking for wrong table
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Course Number")] //test
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