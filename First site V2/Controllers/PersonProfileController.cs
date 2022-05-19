using First_site_V2.Logic.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class PersonProfileController : Controller
    {
        public string _login;
        private static string _friendLogin; 
        private IProfileManager manager;
        public PersonProfileController(IProfileManager manager)
        {
            _login = HomeController._login;
            this.manager = manager;
        }
        [HttpGet]
        public IActionResult PersonProfile(string login)
        {
            if (manager.GetProfile(_login) == null) return RedirectToAction("Login", "Home");
            if (login == _login) return RedirectToAction("Profile", "Page");
            if (login != null)
            _friendLogin=login;
            if(manager.IsFriend(manager.GetProfile(_login).Id, manager.GetProfile(_friendLogin).Id)==false)
            return View(manager.GetProfile(_friendLogin));
            else return View("/Views/PersonProfile/FriendProfile.cshtml", manager.GetProfile(_friendLogin));
        }
        [HttpGet]
        public IActionResult AllPictures(int PersonId)
        {

            return View(manager.GetAllImages(PersonId));
        }
        [HttpGet]
        public IActionResult AddFriend(string login)
        {
            manager.AddFriend(manager.GetProfile(_login).Id, manager.GetProfile(_friendLogin));
            return RedirectToAction("PersonProfile", "PersonProfile");
        }
        [HttpGet]
        public IActionResult RemoveFriend(string login)
        {
            manager.RemoveFriend(manager.GetProfile(_login).Id, manager.GetProfile(_friendLogin));
            return RedirectToAction("PersonProfile", "PersonProfile");
        }
        [HttpGet]
        public IActionResult GetReportOnUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetReportOnUser(string reportText)
        {
            manager.AddReportOnUser(manager.GetIdByLogin(_login), manager.GetIdByLogin( _friendLogin), reportText);
            return RedirectToAction("PersonProfile", "PersonProfile");
        }
    }
}
