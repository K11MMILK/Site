using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{
    public class FriendList
    {
        [Key]
        string login { get; set; }
        List<Profile> Friends { get; set; }

        public FriendList(string login)
        {
            this.login = login; 
            Friends = new List<Profile>();
        }
    }
}
