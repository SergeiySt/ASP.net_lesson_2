using Microsoft.AspNetCore.Mvc;
using Vecherunka_ASP_net.Models;

namespace Vecherunka_ASP_net.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }


        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest) 
        {
            return View("Thanks", guest);
        }
            
        
    }
}
