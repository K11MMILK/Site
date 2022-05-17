using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public int AccessFailedCount {get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; } = " ";
        public byte[] PNG { get; set; }
        public IList<Photo> Photos { get; set; }=new List<Photo>();
        public IList<UserFriend> Friends { get; set; } = new List<UserFriend>();
        public IList<FriendRequest> FriendRequestSent { get; set; } = new List<FriendRequest>();
        public IList<FriendRequest> FriendRequestReceived { get; set; } = new List<FriendRequest>();
        public IList<Post> Posts { get; set; } = new List<Post>();

    }
}
