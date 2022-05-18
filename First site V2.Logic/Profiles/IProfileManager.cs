using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Logic.Profiles;

public interface IProfileManager
{
    int GetIdByLogin(string login);
    Profile GetProfile(string login);
    ICollection<Profile> SearchProfile(string nameorsurname);
    Profile GetProfile(string login, string password);
    IList<Profile> GetAll();
    void AddProfile(string login, string password, string name, string surname);
    int RemoveProfile(string login, string password);
    void AddReport(int Id, string reportText);
    List<Report> GetAllReports();
}
