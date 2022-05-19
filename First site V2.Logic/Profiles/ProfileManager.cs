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
            return context.People.Find(GetIdByLogin(login));
        }
        public Profile GetProfile(string login, string password)
        {
            var profile = context.People.Find(GetIdByLogin(login));
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
            var profile = context.People.Find(GetIdByLogin(login));
            
            if (profile != null)
                if (profile.Password == password)
                {
                    context.Pictures.Remove(context.Pictures.FirstOrDefault(x => x.UserId == GetIdByLogin(login)));
                    context.People.Remove(profile);
                    context.SaveChanges();
                    return 2;
                }
            return 1;
        }

        public void AddReport(int Id, string reportText)
        {
            context.Reports.Add(new Report(reportText, context.People.Find(Id).Name));
            context.SaveChanges();
        }

        public int GetIdByLogin(string login)
        {
            if(context.People.FirstOrDefault(x => x.Login == login)!=null)
                return context.People.FirstOrDefault(x => x.Login == login).Id;
           else
                return 0;
            
            }

        public IList<Report> GetAllReports()
        {
            if(context.Reports != null)
            return context.Reports.ToList();
            else
            {
                return null;
            }
        }

        public void AddPicture(string picture, int Id)
        {
            context.Pictures.Add(new Picture() { Imagin=picture, UserId=Id});
            context.SaveChanges();
        }

        public void AddAvatar(string picture, int Id)
        {
            context.People.Find(Id).PNG = picture;
            context.SaveChanges();
        }

        public IList<Picture> GetAllImages(int Id)
        {
            List<Picture> images = new List<Picture>();
            foreach(var item in context.Pictures.ToList())
            {
                if (item.UserId == Id) images.Add(item);
            }
            return images;
        }
    }
}
