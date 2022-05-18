using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using MyFirstApp.Training.BusinessObject;
using MyFirstApp.Training.Services;

namespace MyFirstApp.Areas.Admin.Models
{
    public class EnrollModel
    {
        public int StudentId { get; set; }
        public string CourseName { get; set; }

        private readonly ICourseService _courseService;

        public EnrollModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public EnrollModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void EnrollStudent()
        {
            var courses = _courseService.GetAllCourses();

            var selectedCourse = courses.Where(x => x.Title == CourseName).FirstOrDefault();

            var student = new Student
            {
                Id = StudentId,
                DOB = DateTime.Now,
                Name = "Jalaluddin",
            };

            _courseService.EnrollStudent(selectedCourse, student);
        }
    }
}
