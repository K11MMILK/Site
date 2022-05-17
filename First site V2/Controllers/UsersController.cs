using First_site_V2.Controllers.Extentions;
using First_site_V2.Logic.Models;
using First_site_V2.Logic.UserManagment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace First_site_V2.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private const int PageSize = 3;

        private IUserManager manager;

        public UsersController(IUserManager _manager)
        {
            manager = _manager;
        }

        public IActionResult Index(int? page)
        {
            var user = manager.UserDetailsFriendsAndPosts(Convert.ToInt32(User.GetUserId()), page ?? 1, PageSize);

            return View(user);
        }

        //public IActionResult AccountDetails(string id, int? page)
        //{
        //    //could be optimized
        //    if (User.GetUserId() == id)
        //    {
        //        ViewData["Authorization"] = "Full";
        //    }
        //    else if (this.manager.CheckIfFriends(Convert.ToInt32(User.GetUserId()), Convert.ToInt32(id)))
        //    {
        //        ViewData["Authorization"] = "Friend";
        //    }
        //    else
        //    {
        //        ViewData["Authorization"] = "None";
        //    }

        //    UserAccountModel user = this.manager.UserDetails(id, page ?? 1, PageSize);

        //    return this.ViewOrNotFound(user);
        //}

        public IActionResult Search(string searchTerm)
        {
            ViewData["searchTerm"] = searchTerm;

            if (string.IsNullOrEmpty(searchTerm))
            {
                var users = manager.GetAll(Convert.ToInt32(User.GetUserId()));
                return View(users);
            }
            else
            {
                var users = this.manager.SearchByNameOrSurname(searchTerm);
                return this.View(users);
            }
        }
    }
}
