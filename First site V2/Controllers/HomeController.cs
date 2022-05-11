using First_site_V2.Logic.Profiles;
using First_site_V2.Models;
using First_site_V2.Storage.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_site_V2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;



        private IProfileManager manager;
        public HomeController(IProfileManager manager)
        {
            this.manager = manager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            diologi_ted_a_ted patau = new diologi_ted_a_ted { };
            return View(patau);
        }
        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            Profile fl = manager.GetProfile(login, password);
            diologi_ted_a_ted patau = new diologi_ted_a_ted { };
            if (login != null)
            {
                if (fl == null)
                {
                    patau.fl = 1;
                }
                else { patau.fl = 2;
                    return View("~/Views/Page/Profile.cshtml", fl);
                }
            }

            return View(patau);
        }


        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registration(string login, string password, string name, string surname)
        {

            manager.AddProfile(login, password, name, surname);
            return View();



            //manager.AddProfile(login, password, name, surname);
            //Profile dick = manager.GetProfile(login, password);
            //return View("~/Views/Page/Profile.cshtml", dick);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DeleteProfile() 
        {
            diologi_ted_a_ted patau = new diologi_ted_a_ted { };
            return View(patau);
        }
        [HttpPost]
        public IActionResult DeleteProfile(string login, string password)
        {
            diologi_ted_a_ted fl=new diologi_ted_a_ted {fl=manager.RemoveProfile(login, password) };
            return View(fl);
        }










        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





    }
}
