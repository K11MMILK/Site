using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Interfaces
{
    public interface IFriendsManager
    {
        ICollection<Profile> GetFriends();
        void AddFriend();
        ICollection<Profile> GetAllPeople();
        Profile GetProfile(int id);
        ICollection<Profile> SearchFriends();
    }
}
