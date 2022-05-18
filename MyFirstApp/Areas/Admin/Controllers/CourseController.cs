using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstApp.Areas.Admin.Models;
using MyFirstApp.Models;
using Microsoft.Extensions.Logging;

namespace MyFirstApp.Areas.Admin.Controllers
{
    public class CourseController : AdminBaseController
    {
        private readonly ILogger<CourseController> _logger;

        public CourseController(ILogger<CourseController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = new CourseModel();
            //model.LoadModelData();
            return View(model);
        }

        public IActionResult Enroll()
        {
            var model = new EnrollModel();
            return View(model);
        }


        public JsonResult GetCourseData()
        {
            var dar = new DataTableAjaxRequestModel(Request);
            var model = new CourseModel();
            var data=model.GetCourses(dar);
            return Json(data);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enroll(EnrollModel model)
        {
            if (ModelState.IsValid)
            {
                //model.EnrollStudent();   
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
