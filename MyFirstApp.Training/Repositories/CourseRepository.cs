﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstApp.Data;
using MyFirstApp.Training.Context;
using MyFirstApp.Training.Entities;

namespace MyFirstApp.Training.Repositories
{
    public class CourseRepository: Repository<Course, int>, ICourseRepository
    {
        public CourseRepository(IMyFirstDbContext context) : base((DbContext) context)
        {

        }
    }
}
