using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{

    public class Profile : Page
    {
        [Key]
        public int Id { get; set; }
        public string Login{ get; set; }
        public string Password{ get; set; }
        public int CommunityId { get; set; }
        public Profile() { }

        public Profile(string login, string password, string name, string surname, string png = "/css/i.png") : base(name, surname)
        {
            Login = login;
            Password = password;
            PNG=png;
        }
    }
}
