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

       public string FriendListId { get; set; }

#pragma warning disable CS8618
        public Profile() { }

        public Profile(string login, string password, string name, string surname, string png = "/css/i.png") : base(name, surname)
        {
            Login = login;
            Password = password;
            Musics = new List<Music> { };
            Videos = new List<Video> { };
            Communities = new List<Community> { };
            FriendListId = login;
            PNG=png;
        }
    }
}
