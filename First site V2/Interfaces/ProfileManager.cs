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
        static Profile human = new Profile() { };
        public ProfileManager(ProfileContext context)
        {
            this.context = context;
        }
        public Profile GetProfile()
        {
            return human;
        }

        public ICollection<Profile> GetFriends()
        {
            return human.Friends;
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
            context.People.Add(new Profile(1, login, password, name, surname));
        }

        public Profile Current(string login, string password)
        {
            foreach (var pennis in context.People)
            {
                if (pennis.login == login)
                {
                    if (pennis.password == password)
                    {
                       human = pennis;
                       return pennis;
                    }
                    else { return null; }
                }
                
            }
            return null;
        }
        public string a() { return context.People[0].name; }
    }
}
