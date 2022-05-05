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
        private IProfileManager pmanager;
        private IFriendsManager fmanager;
        public PageController()
        {
            pmanager = new ProfileManager();
            fmanager = new ProfileManager();
        }
        public IActionResult Profile()
        {
            var Pages = pmanager.GetProfile();
            return View(Pages);
        }
        public IActionResult Friends()
        {
            var Friends = fmanager.GetFriends();
            return View(Friends);
        }
    }
}
