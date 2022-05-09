using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_site_V2.Context;
using First_site_V2.Storage.Entity;

namespace First_site_V2.Interfaces
{
    public class FriendsManager : IFriendsManager
    {
        ProfileContext context;
        public FriendsManager(ProfileContext context)
        {
            this.context = context;
        }
        public void AddFriend()
        {
           
        }
        public Profile GetProfile(int id)
        {
            try
            {
                return context.People.Find(debic => debic.id == id);
            }
            catch
            {
                return null; 
            }
        }
        public ICollection<Profile> GetFriends()
        {
            return context.human.Friends;
        }

        public ICollection<Profile> SearchFriends()
        {
            throw new NotImplementedException();
        }

        public ICollection<Profile> GetAllPeople()
        {
            return context.People;
        }
    }
}
