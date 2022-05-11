using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{

    public class Profile : Page
    {
#pragma warning disable CS8618
        [Key]
        public string Login{ get; set; }
        public string Password{ get; set; }
        List<Music> Musics { get; set; }

        List<Video> Videos { get; set; }

        List<Community> Communities { get; set; }

        public List<Profile> Friends { get; set; }

#pragma warning disable CS8618
        public Profile() { }

        public Profile(string login, string password, string name, string surname, string png = "https://sun9-27.userapi.com/s/v1/ig2/un-BopFJgNcU-iy3esL4JLNdI7QmjxJ3DEGxkksx8rD-ja9O2oqtpiaH5hEby_OvKIljdw8lAijwFHpyWi3eJjkB.jpg?size=320x320&quality=96&type=album") : base(name, surname)
        {
            Login = login;
            Password = password;
            Musics = new List<Music> { };
            Videos = new List<Video> { };
            Communities = new List<Community> { };
            Friends = new List<Profile> { };
            PNG=png;
        }
    }
}
