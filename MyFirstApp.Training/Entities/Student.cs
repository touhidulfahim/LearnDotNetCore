using System;
using System.Collections.Generic;
using MyFirstApp.Data;

namespace MyFirstApp.Training.Entities
{
    public class Student:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public List<CourseStudent> EnrolledCourses { get; set; }
    }
}
