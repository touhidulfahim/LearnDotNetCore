using MyFirstApp.Training.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.Training.Context;

namespace MyFirstApp.Training.Services
{
    public class CourseService : ICourseService
    {
        private readonly MyFirstDbContext _context;

        public CourseService(MyFirstDbContext context)
        {
            _context = context;
        }


        public IList<Course> GetAllCourses()
        {
            var courseList= _context.Courses.ToList();
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
    }
}
