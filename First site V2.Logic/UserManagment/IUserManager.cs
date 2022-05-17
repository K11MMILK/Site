using First_site_V2.Logic.Models;
using Microsoft.AspNetCore.Http;

namespace First_site_V2.Logic.User
{
    public interface IUserManager
    {
        UserModel GetUserById(int id);
        void AddPNG(IFormFile photo, int UserId);
        UserAccountModel UserDetailsFriendsAndPosts(int id, int pageIndex, int pageSize);
        bool CheckIfFriends(int RequestUserId, int AnotherUserId);
        void AddFriend(int senderId, int receiverId);
        void DeleteUser(int id);
        void EditUser(int id, string name, string surname, string login);
        bool UserExist(int id);
    }
}
