using MyFirstApp.Data;
using MyFirstApp.Training.Context;
using MyFirstApp.Training.Entities;
using MyFirstApp.Training.Repositories;

namespace MyFirstApp.Training.UnitOfWorks
{
    public interface ITrainingUnitOfWork: IUnitOfWork
    {
        ICourseRepository Courses { get; }
        IStudentRepository Students { get; }
    }
}