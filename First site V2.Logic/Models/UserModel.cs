using First_site_V2.Logic.Mapping;
using First_site_V2.Storage.Entities;

namespace First_site_V2.Logic.Models
{
    public class UserModel:IMapFrom<User>
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
    }
}
