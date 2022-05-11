using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Logic.Friends

{
    public interface IFriendsManager
    {
        ICollection<Profile> GetFriends();
        void AddFriend();
        IList<Profile> GetAllPeople();
        Profile GetProfile(string login);
        ICollection<Profile> SearchFriends();
    }
}
