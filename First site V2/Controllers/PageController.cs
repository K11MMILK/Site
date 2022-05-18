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
        [HttpGet]
        public IActionResult Profile()
        {
            return View(manager.GetProfile(_login));

        }
        [HttpPost]
        public IActionResult Profile(string login)
        {
            return View();

        }

        [HttpGet]
        public IActionResult Report()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AllPeople()
        {
            var patau=manager.GetAll();
            foreach(var delete in patau)
            {
                if (delete.Login == _login)
                {
                    patau.Remove(delete);
                    break;
                }
            }
            return View(patau);
        }
        [HttpPost]
        public IActionResult AllPeople(string nameorsurname)
        {
            List<Profile> popls = new List<Profile>(manager.SearchProfile(nameorsurname));
            return View(popls);
        }

    }
}
