using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace First_site_V2.Storage.Entity
{
    public class Profile:Page
    {
        
        List<Music> Musics { get; set; }

        List<Video> Videos { get; set; }

        List<Community> Communities { get; set; }

        public List<Profile> Friends { get; set; }

        public Profile() { }

        public Profile(int id, string login, string password, string name, string surname, string png= "https://sun9-27.userapi.com/s/v1/ig2/un-BopFJgNcU-iy3esL4JLNdI7QmjxJ3DEGxkksx8rD-ja9O2oqtpiaH5hEby_OvKIljdw8lAijwFHpyWi3eJjkB.jpg?size=320x320&quality=96&type=album") : base(login, password, name, surname) {
            Musics = new List<Music> { };
            Videos = new List<Video> { };
            Communities = new List<Community> { };
            Friends = new List<Profile> {  };
            this.id = id;
            this.png = png;
        }
    }
}
