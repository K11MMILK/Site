using First_site_V2.Logic.Friends;
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
        public IActionResult Friends(string login)
        {
            return View(manager.GetFriends(login));
        }
        [HttpPost]
        public IActionResult Friends()
        {
            return View("~/Views/Page/PersonProfile.cshtml");
        }
    }
}
