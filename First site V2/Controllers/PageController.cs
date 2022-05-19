using First_site_V2.Logic.Profiles;
using First_site_V2.Storage.Entities;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net.Http.Headers;
using System.Web;
using static System.Net.WebRequestMethods;

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
            if (manager.GetProfile(_login) == null) return RedirectToAction("Login", "Home");
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
        [HttpPost]
        public IActionResult Report(string reportText)
        {
            manager.AddReport(manager.GetIdByLogin(_login), reportText);
            return Content("Ваше мнение очень важно для Вас");
        }
        [HttpGet]
        public IActionResult AllPeople()
        {
            var patau = manager.GetAll();
            foreach (var delete in patau)
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
        public IActionResult AllReports()
        {
            if (manager.GetProfile(_login) == null) return RedirectToAction("Login", "Home");
            return View(manager.GetAllReports());
        }


        [HttpPost]
        public IActionResult AddAvatar(string pictureURL)
        {          
            manager.AddAvatar(pictureURL, manager.GetIdByLogin(_login));
            return RedirectToAction("Profile", "Page");
        }
        [HttpPost]
        public IActionResult AddPicture(string pictureURL)
        {
            manager.AddPicture(pictureURL, manager.GetIdByLogin(_login));
            return RedirectToAction("Profile", "Page");
        }
        [HttpGet]
        public IActionResult AllPictures()
        {
            if (manager.GetProfile(_login) == null) return RedirectToAction("Login", "Home");
            return View(manager.GetAllImages(manager.GetIdByLogin(_login)));
        }
        [HttpGet]
        public IActionResult AllFriends()
        {
            if (manager.GetProfile(_login) == null) return RedirectToAction("Login", "Home");
            var friends = new List<Profile>();
            var friendsId=manager.GetAllFriends(manager.GetIdByLogin(_login));
            foreach(var friendId in friendsId)
            {
                friends.Add(manager.GetProfile(friendId.FriendId));
            }
            return View(friends);
        }
        [HttpPost]
        public IActionResult AllFriends (string nameorsurname)
        {
            List<Profile> popls = new List<Profile>(manager.SearchFriend(nameorsurname, manager.GetIdByLogin(_login)));
            return View(popls);
        }
    }
}
