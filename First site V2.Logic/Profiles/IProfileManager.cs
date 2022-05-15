using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Logic.Profiles;

public interface IProfileManager
{
    Profile GetProfile(string login);
    ICollection<Profile> SearchProfile(string nameorsurname);
    Profile GetProfile(string login, string password);
    IList<Profile> GetAll();
    void AddProfile(string login, string password, string name, string surname);
    int RemoveProfile(string login, string password);
    public void RemoveFriend(string login, string friendLogin);
    public void AddFriend(string login, string friendLogin);
}
