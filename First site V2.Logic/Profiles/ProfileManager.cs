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
        Profile IProfileManager.GetProfile()
        {
            if (context.human == null) return null;
            return context.human;
        }
        public Profile GetProfile(string login, string password)
        {
            foreach (var pennis in context.People)
            {
                if (pennis.Login == login)
                {
                    if (pennis.Password == password)
                    {
                        context.human = pennis;
                        return pennis;
                    }
                    else { return null; }
                }

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
            context.SaveChanges();
        }

        public ICollection<Profile> SearchProfile(string nameorsurname)
        {
            List<Profile> Founded = new List<Profile> { };
            foreach(var cock in context.People)
            {
                if ((cock.Name == nameorsurname) || (cock.Surname == nameorsurname)) Founded.Add(cock);
            }
            return Founded;
        }

        public int RemoveProfile(string login, string password)
        {
            var HumanForDelete = context.People.FirstOrDefault(x => x.Login == login);
            if (HumanForDelete != null)
            {
                if (HumanForDelete.Password == password)
                {
                    context.People.Remove(HumanForDelete);
                    context.SaveChanges();
                    return 2;
                }
            }
            return 1;
            
            

        }
    }
}
