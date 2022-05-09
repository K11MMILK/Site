using First_site_V2.Context;
using First_site_V2.Controllers;
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
        public ProfileManager(ProfileContext context)
        {
            this.context = context;
        }
        Profile IProfileManager.GetProfile()
        {
            if (context.human == null) return null;
            return context.human;
        }
        public Profile GetProfile(string login, string password)
        {
            foreach (var pennis in context.People)
            {
                if (pennis.login == login)
                {
                    if (pennis.password == password)
                    {
                        context.human = pennis;
                        return pennis;
                    }
                    else { return null; }
                }

            }
            return null;
        }

        public ICollection<Profile> GetFriends()
        {
            return context.human.Friends;
        }

        public ICollection<Profile> GetAll()
        {
            return context.People;
        }

        //public Profile PutLP(string login, string password)
        //{
           
        // foreach(var human in context.People)
        //    {
        //        if (human.login == login && human.password == password) { return human; }
        //    }
        //    return null;
        //}

        public void AddProfile(string login, string password, string name, string surname)
        {
            context.People.Add(new Profile(context.People.Count, login, password, name, surname));
        }

        
        public string a() { return context.People[0].name; }

        public void AddFriend()
        {
            
        }

        public ICollection<Profile> SearchFriends()
        {
            return null;
        }
    }
}
