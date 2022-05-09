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
        private IProfileManager pmanager;
        public PageController(IProfileManager pmanager)
        {
            this.pmanager = pmanager;
        }
        public IActionResult Profile()
        {
            Profile Page = pmanager.GetProfile();
            diologi_ted_a_ted fl = new diologi_ted_a_ted();
            fl.fl = 0;
            if (Page.id!=-1)
            {
                Page = pmanager.GetProfile();
                return View(Page);
            }
            return View("~/Views/Home/Login.cshtml", fl);
        }
       
    }
}
