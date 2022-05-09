using First_site_V2.Context;
using First_site_V2.Controllers;
using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Interfaces
{
    public class ProfileManager : IProfileManager
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

       

        public ICollection<Profile> GetAll()
        {
            return context.People;
        }

        public void AddProfile(string login, string password, string name, string surname)
        {
            context.People.Add(new Profile(context.People.Count, login, password, name, surname));
        }

        public ICollection<Profile> SearchProfile(string nameorsurname)
        {
            List<Profile> Founded = new List<Profile> { };
            for(var i = 0; i < context.People.Count; i++)
            {
                if ((context.People[i].name == nameorsurname) || (context.People[i].surname == nameorsurname)) Founded.Add(context.People[i]);
            }
            return Founded;
        }
    }
}
