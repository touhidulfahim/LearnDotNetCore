using MyFirstApp.Data;
using MyFirstApp.Training.Entities;

namespace MyFirstApp.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork: IUnitOfWork
    {
        IRepository<Course> Courses { get; }
        IRepository<Student> Students { get; }
    }
}