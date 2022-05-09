using First_site_V2.Interfaces;
using First_site_V2.Models;
using First_site_V2.Storage.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using First_site_V2.Context;

namespace First_site_V2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


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
                    return View(patau);
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
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





    }
}
