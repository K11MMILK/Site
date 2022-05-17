using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public byte[] PNGinBytes { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public bool IsProfilePNG { get; set; }
    }
}
