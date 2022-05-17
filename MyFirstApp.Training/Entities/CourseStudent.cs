using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Training.Entities
{
    public class CourseStudent
    {
        public int CourseId { get; set; }
        public Course Courses { get; set; }
        public int StudentId { get; set; }
        public Student Students { get; set; }
    }
}
