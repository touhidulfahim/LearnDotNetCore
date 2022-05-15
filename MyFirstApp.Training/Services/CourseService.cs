using MyFirstApp.Training.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.Training.Context;
using MyFirstApp.Training.UnitOfWorks;

namespace MyFirstApp.Training.Services
{
    public class CourseService : ICourseService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;

        public CourseService(ITrainingUnitOfWork trainingUnitOfWork)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
        }

        public IList<Course> GetAllCourses()
        {
            var courseList= _trainingUnitOfWork.Courses.GetAll();
            var courses = new List<Course>();

            foreach (var entity in courseList)
            {
                var course = new Course()
                {
                    Title = entity.Title,
                    Fees = entity.Fees
                };
                courses.Add(course);
            }
            return courses;
        }

        public void CreateCourse(Course course)
        {
            _trainingUnitOfWork.Courses.Add(
                new Entities.Course()
                {
                    Title = course.Title,
                    Fees = course.Fees,
                    StartDate = course.StartDate
                });
            _trainingUnitOfWork.Save();
        }
    }
}
