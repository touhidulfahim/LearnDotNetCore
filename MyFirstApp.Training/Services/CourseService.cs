using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.Common.Utilities;
using MyFirstApp.Training.Context;
using MyFirstApp.Training.Entities;
using MyFirstApp.Training.Exceptions;
using MyFirstApp.Training.UnitOfWorks;
using Course = MyFirstApp.Training.BusinessObject.Course;
using Student = MyFirstApp.Training.BusinessObject.Student;

namespace MyFirstApp.Training.Services
{
    public class CourseService : ICourseService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IDateTimeUtility _dateTimeUtility;

        public CourseService(ITrainingUnitOfWork trainingUnitOfWork, IDateTimeUtility dateTimeUtility)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _dateTimeUtility = dateTimeUtility;
        }

        public IList<Course> GetAllCourses()
        {
            var courseList = _trainingUnitOfWork.Courses.GetAll();
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
            if (course==null)
                throw new InvalidParameterException("Course was not provided");
            if (!IsTitleAlreadyExists(course.Title))
            {
                _trainingUnitOfWork.Courses.Add(
                    new Entities.Course()
                    {
                        Id = course.Id,
                        Title = course.Title,
                        Fees = course.Fees,
                        StartDate = course.StartDate
                    });
                _trainingUnitOfWork.Save();
            }
            else
                throw new InvalidOperationException("Already Used");
        }
        
        public void EnrollStudent(Course course, Student student)
        {
            var courseEntity=_trainingUnitOfWork.Courses.GetById(course.Id);
            if (courseEntity==null)
            {
                throw new InvalidOperationException("Course not found");
            }

            if (courseEntity.EnrolledStudents==null)
            {
                courseEntity.EnrolledStudents = new List<CourseStudent>();
            }
            courseEntity.EnrolledStudents.Add(new CourseStudent
            {
                Students = new Entities.Student
                {
                    Name = student.Name,
                    DOB= student.DOB,
                }
            });
            _trainingUnitOfWork.Save();
        }

        private bool IsTitleAlreadyExists(string title) =>
            _trainingUnitOfWork.Courses.GetCount(x => x.Title == title) > 0;
        private bool IsValidDateTime(DateTime startDateTime) =>
            _trainingUnitOfWork.Courses.GetCount(x => x.Title == title) > 0;

    }
}
