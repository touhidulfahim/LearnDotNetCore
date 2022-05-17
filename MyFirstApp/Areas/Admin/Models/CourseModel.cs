using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using MyFirstApp.Models;
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

        internal object GetCourses(DataTableAjaxRequestModel tableModel)
        {
            var data = _courseService.GetCourses(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "Fees", "StartDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.Title,
                            record.Fees.ToString(),
                            record.StartDate.ToString(),
                            record.Id.ToString()
                        }
                    ).ToArray()
            };
        }

        // public string CourseTitle { get; set; }
        // public string CourseFees { get; set; }
        // public DateTime CourseStartDate { get; set; }


    }
}
