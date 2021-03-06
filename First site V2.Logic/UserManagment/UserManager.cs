using AutoMapper;
using First_site_V2.Logic.Models;
using First_site_V2.Logic.Photoes;
using First_site_V2.Storage;
using First_site_V2.Storage.Entities;
using Microsoft.AspNetCore.Http;

namespace First_site_V2.Logic.UserManagment
{
    public class UserManager : IUserManager
    {
        GaisContext context;
        IPhotoManager photoManager;
        Mapper mapper;
        public UserManager(GaisContext _context, IPhotoManager _photoManager, Mapper _mapper)
        {
            context = _context;
            photoManager = _photoManager;
            mapper = _mapper;
        }

        public IList<User> GetAll(int Id)
        {
            var person=context.Users.ToList();
            foreach(var delete in person)
            {
                if (Convert.ToInt32(delete.Id) == Id)
                {
                    person.Remove(delete);
                    break;
                }
            }
            return person;
        }

        public IList<User> SearchByNameOrSurname(string NameOrSurname)
        {
            var person = context.Users.ToList();
            var godnye = new List<User>();
            foreach (var delete in person)
            {
                if (delete.FirstName == NameOrSurname||delete.LastName==NameOrSurname)
                {
                    godnye.Add(delete);
                    
                }
            }
            return godnye;
        }

        public void AddFriend(int senderId, int receiverId)
        {
            if (UserExist(senderId)&&UserExist(receiverId)&&!CheckIfFriends(senderId,receiverId))
            {
                var Friend = new UserFriend() { UserId = senderId, FriendId = receiverId };
                context.Friends.Add(Friend);
                context.SaveChanges();
            }
        }
        public bool UserExist(int id)
        {
            if (context.Users.Find(id)!=null)
                return true;
            else 
                return false;
        }

        public void AddPNG(IFormFile photo, int UserId)
        {
            if (UserExist(UserId))
            {
                var user = context.Users.Find(UserId);
                user.PNG = photoManager.PNGInBytes(photo);
                context.SaveChanges();
            }
        }

        public bool CheckIfFriends(int RequestUserId, int AnotherUserId)
        {
            return context.Friends.Any(x=>(x.UserId==RequestUserId&&x.FriendId==AnotherUserId)||(x.UserId == AnotherUserId && x.FriendId == RequestUserId));
        }

        public void DeleteUser(int id)
        {
            var user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public void EditUser(int id, string name, string surname, string login)
        {
            var user = context.Users.Find(id);
            user.FirstName = name;
            user.LastName = surname;
            user.Email = login;
            //context.User.Update(user);
            context.SaveChanges();
        }

        public UserModel GetUserById(int id)
        {
            if (UserExist(id)) 
                return mapper.Map<UserModel>(context.Users.Find(id));
            else return null;
        }

        public User UserDetailsFriendsAndPosts(int id, int pageIndex, int pageSize)
        {
            if (UserExist(id))
            {
                var accountmodel = context.Users.Where(x => Convert.ToInt32(x.Id) == id).FirstOrDefault();
                return accountmodel;
            }
            else return null;

        }
    }
}