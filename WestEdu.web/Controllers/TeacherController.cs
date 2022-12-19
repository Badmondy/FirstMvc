using System;
using System.Collections.Generic;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using WestEdu.web.Models;

namespace WestEdu.web.Controllers
{
   
    public class TeacherController : Controller
    {
        
        public IActionResult Index()
        {

            //Michael
            var Michael = new Teacher();

            Michael.myCourses.Add(new Course{
                CourseName = "MVC ASP.NET",
            });

            Michael.FirstName = "Micheal";

            Michael.LastName = "Gustavsson";

            Michael.profilepic = "https://images.unsplash.com/photo-1457449940276-e8deed18bfff?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1470&q=80";
            var Kalle = new Teacher();

            //Kalle
            Kalle.myCourses.Add(new Course{
                CourseName = "IT-Säkerhet"
            });

            Kalle.FirstName = "Kalle";

            Kalle.LastName = "Halvarsson";

            Kalle.profilepic = "https://images.unsplash.com/photo-1497316730643-415fac54a2af?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=764&q=80";
          
            var allTeachers = new List<Teacher>{
                Michael,
                Kalle
            };  




            
            return View("Index", allTeachers);
        }

    }
}