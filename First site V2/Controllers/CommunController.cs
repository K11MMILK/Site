using First_site_V2.Logic.Communities;
using First_site_V2.Logic.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class CommunController : Controller
    {
        private ICommunityManager manager;
        private IProfileManager pmanager;
        private string login;
        public CommunController(ICommunityManager _manager, IProfileManager _pmanager)
        {
            pmanager = _pmanager;
            manager = _manager;
            login = HomeController._login;
        }
        [HttpGet]
        public IActionResult AllCommunities()
        {
            if (pmanager.GetProfile(login) == null)
                return RedirectToAction("Login", "Home");
            return View(manager.GetAll());
        }
        [HttpPost]
        public IActionResult ToCommunity(int id)
        {
            return View(manager.GetCommunity(id));
        }
        [HttpGet]
        public IActionResult JoinToCommunity(int id, int a = 1)
        {
            manager.JoinToCommunity(manager.GetMember(login).Id, id);
            return View("ToCommunity", manager.GetCommunity(id));
        }
        [HttpGet]
        public IActionResult CreateNewCommunity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewCommunity(string name)
        {
            var id = manager.CreateCommunity(name);

            return RedirectToAction("AllCommunities", "Commun");
        }
        [HttpPost]
        public IActionResult Members(int id)
        {
            return View(manager.GetAllMembers(id));
        }

    }
}
