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
        User IProfileManager.GetProfile(string login)
        {
            return context.User.Find(login);
        }
        public User GetProfile(string login, string password)
        {
            var profile = context.User.Find(login);
            if (profile != null)
                if (profile.Password == password)
                {
                    return profile;
                }
            return null;
        }
        public IList<User> GetAll()
        {
            return context.User.ToList();
        }



        public  void AddProfile(string login, string password, string name, string surname)
        {
            var p = new User(login, password, name, surname);
            context.User.Add(p);
            var i = context.User.Find(login).Friends;
            context.Friends.Add(i);
            context.SaveChanges();
        }




        public ICollection<User> SearchProfile(string nameorsurname)
        {
            List<User> Founded = new List<User> { };
            foreach(var person in context.User)
            {
                if ((person.Name == nameorsurname) || (person.Surname == nameorsurname)) 
                    Founded.Add(person);
            }
            return Founded;
        }

        public int RemoveProfile(string login, string password)
        {
            var profile = context.User.Find(login);
            
            var pp = context.Friends.ToList();
            if (profile != null)
                if (profile.Password == password)
                {
                    context.User.Remove(profile);
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
            var a = context.User.Find(login).Friends;
            var penns = context.Friends.Find(1);
            var cock = context.User.Find(friendLogin);
            
           
            penns.Friends.Add(cock);
            context.Friends.Update(penns);
            context.SaveChanges();
        }
        public void RemoveFriend(string login, string friendLogin)
        {
            //var person = context.People.Find(login);
            //context.Friends.Find(login).Friends.Remove(context.People.Find(friendLogin));
            //context.People.Update(person); 

            context.User.Find(login).Friends.Friends.Remove(context.User.Find(friendLogin));
            context.SaveChanges();
        }
    }
}
