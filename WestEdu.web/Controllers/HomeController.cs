
using Microsoft.AspNetCore.Mvc;


namespace WestEdu.web.Controllers;

public class HomeController : Controller
{

     public IActionResult Index()
    {
    
        return View("Index");
    }
 
}
