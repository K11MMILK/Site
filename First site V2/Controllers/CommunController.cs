using First_site_V2.Logic.Communities;
using First_site_V2.Logic.Profiles;
using First_site_V2.Storage.Entities;
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

            return View(manager.GetAll());
        }
        [HttpPost]
        public IActionResult AllCommunities(string name)
        {

            return View(manager.SearchCommunity(name));
        }
        [HttpPost]
        public IActionResult ToCommunity(int id)
        {
            if (pmanager.GetProfile(login).CommunityId != id)
                return View(manager.GetCommunity(id));
            else return View("ToFriendCommunity", manager.GetCommunity(id));
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
        [HttpGet]
        public IActionResult DeleteCommunity(int id)
        {
            manager.DeleteCommunity(id);
            return View("AllCommunities", manager.GetAll());
        }
        [HttpPost]
        public IActionResult LeaveCommunity(int id)
        {
            manager.LeaveCommunity(id);
            return View("/Views/Commun/ToCommunity.cshtml", manager.GetCommunity(id));
        }
    }
}
