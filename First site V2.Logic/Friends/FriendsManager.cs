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
        public void AddFriend(string login, string friendLogin)
        {
            var person = context.People.Find(login);
            person.Friends.Add(context.People.Find(friendLogin));
            context.People.Update(person); //тут возможно по другому, я не уверена
            context.SaveChanges();
        }
        public void RemoveFriend(string login, string friendLogin)
        {
            var person = context.People.Find(login);
            person.Friends.Remove(context.People.Find(friendLogin));
            context.People.Update(person); //тут возможно по другому, я не уверена
            context.SaveChanges();
        }
        public Profile GetProfile(string login)
        {
            return context.People.Find(login);
        }
        public ICollection<Profile> GetFriends(string login)
        {
            var person = context.People.Find(login);
            if(person== null) return null;
            return person.Friends;
        }
        public ICollection<Profile> SearchFriends(string login, string nameorsurname)
        {
            var person = context.People.Find(login);
            var Founded = new List<Profile>();
            foreach (var friend in person.Friends)
            {
                if ((friend.Name == nameorsurname) || (friend.Surname == nameorsurname))
                    Founded.Add(friend);
            }
            return Founded;
        }
        public IList<Profile> GetAllPeople()
        {
            return context.People.ToList();
        }
    }
}
