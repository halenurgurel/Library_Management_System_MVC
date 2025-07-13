using System.Diagnostics;
using Library_Management_System_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Library_Management_System_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //Home'un indexi bize anasayfayý verecek.

        {
            return View();

        }

        public IActionResult About()
        {
            return View();
        }
    }
}
