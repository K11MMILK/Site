using First_site_V2.Logic.Friends;
using Microsoft.AspNetCore.Mvc;


namespace First_site_V2.Controllers
{
    public class FriendsController : Controller
    {
        public static string _login { get; set; }

        private IFriendsManager manager;
        public FriendsController(IFriendsManager manager)
        {
            this.manager = manager;
            _login = HomeController._login;
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
