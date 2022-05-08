using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_site_V2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class FriendsController : Controller
    {

        private IFriendsManager fmanager;

        public IActionResult Friends()
        {
            var Friends = fmanager.GetFriends();
            return View(Friends);
        }
    }
}
