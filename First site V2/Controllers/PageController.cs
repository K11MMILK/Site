using First_site_V2.Interfaces;
using First_site_V2.Storage.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Controllers
{
    public class PageController : Controller
    {
        private IProfileManager manager;
        public PageController(IProfileManager manager)
        {
            this.manager = manager;
        }
        public IActionResult Profile()
        {
            Profile Page = manager.GetProfile();
            diologi_ted_a_ted fl = new diologi_ted_a_ted();
            fl.fl = 0;
            if (Page.id!=-1)
            {
                Page = manager.GetProfile();
                return View(Page);
            }
            return View("~/Views/Home/Login.cshtml", fl);
        }
        [HttpGet]
        public IActionResult AllPeople()
        {
            return View(manager.GetAll());
        }
        [HttpPost]
        public IActionResult AllPeople(string nameorsurname)
        {
            List<Profile> popls = new List<Profile>(manager.SearchProfile(nameorsurname));
            return View(popls);
        }

    }
}
