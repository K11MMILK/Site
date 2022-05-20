using First_site_V2.Logic.Communities;
using First_site_V2.Storage.Entities;
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
        public IActionResult JoinToCommunity(int id, int a=1)
        {
            manager.JoinToCommunity(manager.GetMember(login).Id, id);
            return View("ToCommunity",manager.GetCommunity(id));
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
        [HttpPost]
        public IActionResult Members(int id)
        {
            return View(manager.GetAllMembers(id));
        }
        [HttpGet]
        public IActionResult NewPost(int communityId)
        {
            return View(manager.GetCommunity(communityId));
        }
        [HttpPost]
        public IActionResult NewPost(int communityId, string postText, string png)
        {
            manager.AddNewPost(communityId, postText, png);

            return View("ToCommunity", manager.GetCommunity(communityId));
        }
        [HttpPost]
        public IActionResult AllPosts(int id)
        {
            return View(manager.GetAllPosts(id));
        }

    }
}
