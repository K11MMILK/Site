using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Logic.Friends

{
    public interface IFriendsManager
    {
        ICollection<User> GetFriends(string login);
        void AddFriend(string login, string friendLogin);
        void RemoveFriend(string login, string friendLogin);
        IList<User> GetAllPeople();
        User GetProfile(string login);
        ICollection<User> SearchFriends(string login, string nameorsurname);
    }
}
