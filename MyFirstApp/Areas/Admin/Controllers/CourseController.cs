using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstApp.Areas.Admin.Models;

namespace MyFirstApp.Areas.Admin.Controllers
{
    public class CourseController : AdminBaseController
    {
        public IActionResult Index()
        {
            var model = new CourseModel();
            model.LoadModelData();
            return View(model);
        }

        public IActionResult Enroll()
        {
            var model = new EnrollModel();
            return View(model);
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
