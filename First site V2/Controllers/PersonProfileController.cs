using First_site_V2.Logic.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class PersonProfileController : Controller
    {
        public string _login;
        private IProfileManager manager;
        public PersonProfileController(IProfileManager manager)
        {
            _login = HomeController._login;
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult PersonProfile(string login)
        {
            
            return View(manager.GetProfile(login));
        }
        [HttpPost]
        public IActionResult PersonProfile(string login, int a)
        {
            manager.AddFriend(_login, login);
            return View(manager.GetProfile(login));
        }
    }
}
