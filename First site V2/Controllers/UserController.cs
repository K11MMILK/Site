using First_site_V2.Logic.Models;
using First_site_V2.Logic.User;
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
            UserAccountModel user = this.manager.UserDetailsFriendsCommentsAndPosts(this.User.GetUserId(), page ?? 1, PageSize);

            return this.ViewOrNotFound(user);
        }

        public IActionResult AccountDetails(string id, int? page)
        {
            //could be optimized
            if (User.GetUserId() == id)
            {
                ViewData[GlobalConstants.Authorization] = GlobalConstants.FullAuthorization;
            }
            else if (this.manager.CheckIfFriends(User.GetUserId(), id))
            {
                ViewData[GlobalConstants.Authorization] = GlobalConstants.FriendAuthorization;
            }
            else
            {
                ViewData[GlobalConstants.Authorization] = GlobalConstants.NoAuthorization;
            }

            UserAccountModel user = this.manager.UserDetails(id, page ?? 1, PageSize);

            return this.ViewOrNotFound(user);
        }

        public IActionResult Search(string searchTerm, int? page)
        {
            ViewData[GlobalConstants.SearchTerm] = searchTerm;

            if (string.IsNullOrEmpty(searchTerm))
            {
                var users = this.manager.All(page ?? 1, PageSize);
                return this.ViewOrNotFound(users);
            }
            else
            {
                var users = this.manager.UsersBySearchTerm(searchTerm, page ?? 1, PageSize);
                return this.ViewOrNotFound(users);
            }
        }
    }
}
