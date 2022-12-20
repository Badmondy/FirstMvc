
using Microsoft.AspNetCore.Mvc;

using WestEdu.web.Models;

namespace WestEdu.web.Controllers
{

    public class ShopCartController : Controller
    {
   

        public IActionResult Index()
        {
            ShopCart b1 = new ShopCart();

            b1.CoursesToBuy.Add(new Course{CourseName="MVC ASP.NET med Micheal", CoursePrice = 5500});
            b1.CoursesToBuy.Add(new Course{CourseName="IT-Säkerhet", CoursePrice = 2500});


            var allItems = new List<ShopCart>();
            allItems.Add(
                b1
            );
            return View("Index", allItems);
        }

        [Route("ShopCart/{FinalPrice}")]
        public IActionResult Checkout(int finalprice){
            
            return View("Checkout");
        }




    }
}