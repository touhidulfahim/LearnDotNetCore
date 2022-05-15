using Microsoft.EntityFrameworkCore;
using MyFirstApp.Data;
using MyFirstApp.Training.Context;
using MyFirstApp.Training.Entities;
using MyFirstApp.Training.Repositories;


namespace MyFirstApp.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public IStudentRepository Students { get; private set; }
        public ICourseRepository Courses { get; private set; }
        
        public TrainingUnitOfWork(IMyFirstDbContext context,
            IStudentRepository students, ICourseRepository courses
            ) : base((DbContext)context)
        {
            Students = students;
            Courses = courses;
        }

    }
}
