using First_site_V2.Logic.Communities;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class CommunController : Controller
    {
        public ICommunityManager manager;
        public string login;
        public CommunController(ICommunityManager _manager)
        {
            manager = _manager;
            login = HomeController._login;
        }
        [HttpGet]
        public IActionResult AllCommunities()
        {

            return View(manager.GetAll());
        }
        [HttpPost]
        public IActionResult ToCommunity(int id)
        {
            return View(manager.GetCommunity(id));
        }
        [HttpGet]
        public IActionResult ToCommunity(int id, int a=1)
        {
            manager.JoinToCommunity(manager.GetMember(login).Id, id);
            return View(manager.GetCommunity(id));
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

            return RedirectToAction("AllCommunities","Commun");
        }

    }
}
