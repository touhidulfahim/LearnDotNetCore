﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Training.BusinessObject
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }
        public DateTime StartDate { get; set; }
    }
}
