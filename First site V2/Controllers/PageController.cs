using First_site_V2.Interfaces;
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
        public PageController()
        {
            manager = new ProfileManager();
        }
        public IActionResult Profile()
        {
            var Pages = manager.GetPage();
            return View(Pages);
        }
        public IActionResult Friends()
        {
            var Friends = manager.GetFriends();
        }
    }
}
