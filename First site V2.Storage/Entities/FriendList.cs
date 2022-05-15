using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{
    public class FriendList
    {
        [Key]
        public string Login { get; set; }
        public List<Profile> Friends { get; set; }

        public FriendList(string login)
        {
            this.Login = login; 
            Friends = new List<Profile>();
        }
    }
}
