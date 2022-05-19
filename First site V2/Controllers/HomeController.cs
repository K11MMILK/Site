using First_site_V2.Logic.Profiles;
using First_site_V2.Models;
using First_site_V2.Storage.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_site_V2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        public static string _login { get; set; }


        private IProfileManager manager;
        public HomeController(IProfileManager manager)
        {
            this.manager = manager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            diologi_ted_a_ted fl = new diologi_ted_a_ted { };
            return View(fl);
        }
        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            _login = login;
            Profile patau = manager.GetProfile(login, password);
            diologi_ted_a_ted fl = new diologi_ted_a_ted { };
            if (login != null)
            {
                if (patau== null)
                {
                    fl.fl = 1;
                }
                else { fl.fl = 2;
                    return View("/Views/Page/Profile.cshtml", patau);
                }
            }

            return View(fl);
        }


        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Registration(string login, string password, string name, string surname)
        {
            if (manager.GetProfile(login) == null)
            {
                manager.AddProfile(login, password, name, surname);
                _login = login;
                return View("/Views/Page/Profile.cshtml", manager.GetProfile(login));
            }
            else
            {
                return View(new diologi_ted_a_ted() { fl=1});
            }
            
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
