using First_site_V2.Storage.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{
    public class FriendRequest
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public User Sender { get; set; }
        public int ReceiverId { get; set; }
        public User Receiver { get; set; }
        [Required]
        public FriendRequestStatus FriendRequestStatus { get; set; }
    }
}
