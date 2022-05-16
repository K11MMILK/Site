using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{
    public class FriendList
    {
        [Key]
        public int Id { get; set; }
        public List<Profile> Friends { get; set; }
        public FriendList(){ }
        public FriendList(string login)
        {
           Friends = new List<Profile>();
        }
    }
}
