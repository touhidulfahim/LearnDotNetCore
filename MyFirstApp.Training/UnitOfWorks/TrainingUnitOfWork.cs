using Microsoft.EntityFrameworkCore;
using MyFirstApp.Data;
using MyFirstApp.Training.Context;
using MyFirstApp.Training.Entities;
using MyFirstApp.Training.Repositories;


namespace MyFirstApp.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public IRepository<Student> Students { get; private set; }
        public IRepository<Course> Courses { get; private set; }

        public TrainingUnitOfWork(MyFirstDbContext context) : base(context)
        {
            Students = new StudentRepository(context);
            Courses = new CourseRepository(context);
        }

    }
}
