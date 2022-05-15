using First_site_V2.Storage;
using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Logic.Profiles
{
    public class ProfileManager : IProfileManager
    {
        GaisContext context;
        public ProfileManager(GaisContext context)
        {
            this.context = context;
        }
        Profile IProfileManager.GetProfile(string login)
        {
            return context.People.Find(login);
        }
        public Profile GetProfile(string login, string password)
        {
            var profile = context.People.Find(login);
            if (profile != null)
                if (profile.Password == password)
                {
                    return profile;
                }
            return null;
        }
        public IList<Profile> GetAll()
        {
            return context.People.ToList();
        }

        public  void AddProfile(string login, string password, string name, string surname)
        {
            context.People.Add(new Profile(login, password, name, surname));
            context.Friends.Add(new FriendList(login));
            context.SaveChanges();
        }

        public ICollection<Profile> SearchProfile(string nameorsurname)
        {
            List<Profile> Founded = new List<Profile> { };
            foreach(var person in context.People)
            {
                if ((person.Name == nameorsurname) || (person.Surname == nameorsurname)) 
                    Founded.Add(person);
            }
            return Founded;
        }

        public int RemoveProfile(string login, string password)
        {
            var profile = context.People.Find(login);
            
            var pp = context.Friends.ToList();
            if (profile != null)
                if (profile.Password == password)
                {
                    context.People.Remove(profile);
                    context.Friends.Remove(context.Friends.Find(login));
                    context.SaveChanges();
                    return 2;
                }
            return 1;
            //var HumanForDelete = context.People.FirstOrDefault(x => x.Login == login);
            //if (HumanForDelete != null)
            //{
            //    if (HumanForDelete.Password == password)
            //    {
            //        context.People.Remove(HumanForDelete);
            //        context.SaveChanges();
            //        return 2;
            //    }
            //}
            //return 1;
        }

        public void AddFriend(string login, string friendLogin)
        {
            var person = context.People.Find(login);
            //context.Friends.Add(new FriendList(login));
            context.Friends.Find(login).Friends.Add(context.People.Find(friendLogin));
            context.People.Update(person);
            context.SaveChanges();
        }
        public void RemoveFriend(string login, string friendLogin)
        {
            var person = context.People.Find(login);
            context.Friends.Find(login).Friends.Remove(context.People.Find(friendLogin));
            context.People.Update(person); 
            context.SaveChanges();
        }
    }
}
