﻿namespace MyFirstApp.Training.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public Course Courses { get; set; }
    }
}
