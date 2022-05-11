using First_site_V2.Storage;
using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Logic.Friends
{
#pragma warning disable CS8603
    public class FriendsManager : IFriendsManager
    {
        GaisContext context;
        public FriendsManager(GaisContext context)
        {
            this.context = context;
        }
        public void AddFriend()
        {
           
        }
        public Profile GetProfile(string login)
        {
            try
            {

                return context.People.Find(login);
            }
            catch
            {
                return null;
            }
        }
        public ICollection<Profile> GetFriends()
        {
            return context.human.Friends;
        }

        public ICollection<Profile> SearchFriends()
        {
            throw new NotImplementedException();
        }

        public IList<Profile> GetAllPeople()
        {
            return context.People.ToList();
        }
    }
}
