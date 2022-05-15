using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Training.Services
{
    public interface ICourseService
    {
        IList<BusinessObject.Course> GetAllCourses();
    }
}
