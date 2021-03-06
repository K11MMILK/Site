using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public byte[] Photo { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
