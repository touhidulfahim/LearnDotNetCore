using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using MyFirstApp.Training.BusinessObject;
using MyFirstApp.Training.Services;

namespace MyFirstApp.Areas.Admin.Models
{
    public class CourseModel
    {
        private ICourseService _courseService;
        public IList<Course> Courses { get; set; }
        public CourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }

        public CourseModel(ICourseService courseService)
        {

        }
        
        public void LoadModelData()
        {
            Courses = _courseService.GetAllCourses();
        }

        // public string CourseTitle { get; set; }
        // public string CourseFees { get; set; }
        // public DateTime CourseStartDate { get; set; }


    }
}
