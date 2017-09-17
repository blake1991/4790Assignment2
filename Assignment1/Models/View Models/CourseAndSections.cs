using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models.View_Models
{
    public class CourseAndSections
    {
        public Course course { get; set; }
        public List<Section> sections { get; set; }
    }
}