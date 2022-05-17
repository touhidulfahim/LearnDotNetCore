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
        private readonly ICourseService _courseService;

        public EnrollModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public EnrollModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public void EnrollStudent(string courseName, int studentId)
        {
            var courses = _courseService.GetAllCourses();
            var selectedCourses = courses.Where(x=>x.Title==courseName).FirstOrDefault();
            var student = new Student()
            {
                Id = studentId,
                DOB = DateTime.Now,
                Name = "Harami"
            };
            _courseService.EnrollStudent(selectedCourses,student);
        }
    }
}
