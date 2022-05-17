using System;
using System.Collections.Generic;
using MyFirstApp.Data;

namespace MyFirstApp.Training.Entities
{
    public class Course:IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        public DateTime StartDate { get; set; }
        public List<Topic> Topics { get; set; }
        public List<CourseStudent> EnrolledStudents { get; set; }
    }
}
