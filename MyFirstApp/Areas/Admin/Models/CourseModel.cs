using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Http;
using MyFirstApp.Models;
using MyFirstApp.Training.BusinessObject;
using MyFirstApp.Training.Services;

namespace MyFirstApp.Areas.Admin.Models
{
    public class CourseModel
    {
        private ICourseService _courseService;
        private IHttpContextAccessor _httpContextAccessor;

        public CourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
            _httpContextAccessor = Startup.AutofacContainer.Resolve<IHttpContextAccessor>();
        }

        public CourseModel(ICourseService courseService, IHttpContextAccessor httpContextAccessor)
        {
            _courseService = courseService;
            _httpContextAccessor = httpContextAccessor;
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

        internal void Delete(int id)
        {
            _courseService.DeleteCourse(id);
        }
    }
}
