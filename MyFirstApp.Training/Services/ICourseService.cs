using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApp.Training.BusinessObject;

namespace MyFirstApp.Training.Services
{
    public interface ICourseService
    {
        IList<BusinessObject.Course> GetAllCourses();
        void EnrollStudent(Course course, Student student);
    }
}
