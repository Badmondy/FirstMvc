
using System.IO;
using Microsoft.AspNetCore.Mvc;

using WestEdu.web.Models;

namespace WestEdu.web.Controllers
{

 
    public class CourseController : Controller
    {
        List<Course> Kurser = new List<Course>();
        public IActionResult Index()
        {

            Kurser = new List<Course>{
                new Course{CourseId = Guid.NewGuid(), CourseName = "MVC ASP.NET med Micheal", StartDate = DateTime.Now.AddDays(15), EndDate = DateTime.Now.AddMonths(1), CourseNumber = 2342, CoursePrice = 5500},
                new Course{CourseId = Guid.NewGuid(), CourseName = "IT-Säkerhet", StartDate = DateTime.Now.AddDays(30), EndDate = DateTime.Now.AddMonths(2), CourseNumber = 2352, CoursePrice = 2500}
            };

            
            return View("Index", Kurser);
        }

     [HttpGet("Course/{pdfID}")]
     public IActionResult Download(int pdfID)
     {  
        var filepath = $"wwwroot/pdf/{pdfID.ToString()}.pdf";
        if(System.IO.File.Exists(filepath)){
            return File(System.IO.File.ReadAllBytes(filepath), "application/pdf", System.IO.Path.GetFileName(filepath));
        }else{
            return RedirectToAction("Index");
        }

    
       

       
        
        
        
      
     }
    

    }
}