
using Microsoft.AspNetCore.Mvc;

using WestEdu.web.Models;

namespace WestEdu.web.Controllers
{

    public class CourseController : Controller
    {
    
        public IActionResult Index()
        {

            var t = new List<Course>{
                new Course{CourseId = Guid.NewGuid(), CourseName = "MVC ASP.NET med Micheal", StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddMonths(1), CourseNumber = 2342},
                new Course{CourseId = Guid.NewGuid(), CourseName = "IT-Säkerhet", StartDate = DateTime.Now.AddDays(30), EndDate = DateTime.Now.AddMonths(2), CourseNumber = 2352}
            };
            return View("Index", t);
        }
    }
}