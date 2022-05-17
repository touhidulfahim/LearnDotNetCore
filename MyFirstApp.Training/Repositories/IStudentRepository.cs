﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.Data;
using MyFirstApp.Training.Context;
using MyFirstApp.Training.Entities;

namespace MyFirstApp.Training.Repositories
{
    public interface IStudentRepository: 
        IRepository<Student, int>
    {

    }
}
