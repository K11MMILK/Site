using First_site_V2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_site_V2.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Users");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}