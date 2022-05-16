using First_site_V2.Logic.Friends;
using Microsoft.AspNetCore.Mvc;


namespace First_site_V2.Controllers
{
    public class FriendsController : Controller
    {
        public string _login { get; set; }

        private IFriendsManager manager;
        public FriendsController(IFriendsManager manager)
        {
            this.manager = manager;
            _login = HomeController._login;
        }
        [HttpGet]
        public IActionResult Friends()
        {
            return View(manager.GetFriends(_login));
        }
        [HttpPost]
        public IActionResult Friends(int a)
        {
            return View("~/Views/Page/PersonProfile.cshtml");
        }
    }
}
