using First_site_V2.Logic.Models;
using First_site_V2.Storage.Entities;
using Microsoft.AspNetCore.Http;

namespace First_site_V2.Logic.UserManagment
{
    public interface IUserManager
    {
        IList<User> GetAll(int Id);
        IList<User> SearchByNameOrSurname(string NameOrSurname);
        UserModel GetUserById(int id);
        void AddPNG(IFormFile photo, int UserId);
        User UserDetailsFriendsAndPosts(int id, int pageIndex, int pageSize);
        bool CheckIfFriends(int RequestUserId, int AnotherUserId);
        void AddFriend(int senderId, int receiverId);
        void DeleteUser(int id);
        void EditUser(int id, string name, string surname, string login);
        bool UserExist(int id);
    }
}
