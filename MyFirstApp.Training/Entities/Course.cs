using System;
using System.Collections.Generic;

namespace MyFirstApp.Training.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        public DateTime StartDate { get; set; }
        public List<Topic> Topics { get; set; }
    }
}
