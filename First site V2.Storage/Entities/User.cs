using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{

    public class User : IdentityUser
    {

        [Key]
        public int Id { get; set; }
        public string Login{ get; set; }
        public string Password{ get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Status { get; set; }
        public byte[] PNG { get; set; }
        public IList<UserFriend> Friends { get; set; } = new List<UserFriend>();
        public IList<FriendRequest> FriendRequestSent { get; set; } = new List<FriendRequest>();
        public IList<FriendRequest> FriendRequestReceived { get; set; } = new List<FriendRequest>();
        public IList<Post> Posts { get; set; } = new List<Post>();
        public User() { }

        public User(string login, string password, string name, string surname)
        {
            Name = name;
            Surname = surname;
            Status = " ";
            Login = login;
            Password = password;
        }
    }
}
