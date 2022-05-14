using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp.Areas.Admin.Controllers
{
    public class CourseController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
