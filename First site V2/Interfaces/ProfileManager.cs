using First_site_V2.Context;
using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Interfaces
{
    public class ProfileManager : IProfileManager, IFriendsManager
    {
        ProfileContext context;
        public ProfileManager()
        {
            context = new ProfileContext();
        }
        public Profile GetProfile()
        {
            return context.People[0];

        }

        public ICollection<Profile> GetFriends()
        {
            return context.People[0].Friends;
        }

        public ICollection<Profile> GetAll()
        {
            return context.People;
        }

        public Profile PutLP(string login, string password)
        {
           
         foreach(var human in context.People)
            {
                if (human.login == login && human.password == password) { return human; }
            }
            return null;
        }

    }
}
