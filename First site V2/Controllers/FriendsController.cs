using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_site_V2.Interfaces;
using First_site_V2.Storage.Entity;
using Microsoft.AspNetCore.Mvc;


namespace First_site_V2.Controllers
{
    public class FriendsController : Controller
    {
        
        private IFriendsManager manager;
        public FriendsController(IFriendsManager manager)
        {
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult Friends()
        {
            return View(manager.GetFriends());
        }
        [HttpPost]
        public IActionResult Friends(int id)
        {

            return View("~/Views/Page/PersonProfile.cshtml");
        }
    }
}
