using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Logic.Friends

{
    public interface IFriendsManager
    {
        ICollection<Profile> GetFriends(string login);
        void AddFriend(string login, string friendLogin);
        void RemoveFriend(string login, string friendLogin);
        IList<Profile> GetAllPeople();
        Profile GetProfile(string login);
        ICollection<Profile> SearchFriends(string login, string nameorsurname);
    }
}
