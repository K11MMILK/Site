using First_site_V2.Logic.Profiles;
using First_site_V2.Storage.Entities;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    public class PageController : Controller
    {
        private IProfileManager manager;
        public string _login { get; set; }
        public PageController(IProfileManager manager)
        {
            this.manager = manager;
            _login = HomeController._login;
        }
        public IActionResult Profile()
        {
            Profile Page = manager.GetProfile(_login);
            diologi_ted_a_ted fl = new diologi_ted_a_ted();
            fl.fl = 0;
            if (Page!=null&&Page.Login!=null)
            {
                Page = manager.GetProfile(_login);
                return View(Page);
            }
            return View("~/Views/Home/Login.cshtml", fl);
        }
        [HttpGet]
        public IActionResult AllPeople()
        {
            return View(manager.GetAll());
        }
        [HttpPost]
        public IActionResult AllPeople(string nameorsurname)
        {
            List<Profile> popls = new List<Profile>(manager.SearchProfile(nameorsurname));
            return View(popls);
        }

    }
}
