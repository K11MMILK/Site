using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_site_V2.Storage.Entities
{
    public class FriendList
    {
        [Key]
        [ForeignKey("Profile")]
        public int Id { get; set; }
        public List<Profile> Friends { get; set; }
        public FriendList(){ }
        public FriendList(int id)
        {
           Friends = new List<Profile>();
        }
    }
}
