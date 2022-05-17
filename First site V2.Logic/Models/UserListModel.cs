using First_site_V2.Logic.Mapping;
using First_site_V2.Storage.Entities;
using AutoMapper;

namespace First_site_V2.Logic.Models
{
    public class UserListModel : IMapFrom<User>, IHaveCustomMapping
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int NumberOfPosts { get; set; }
        public byte[] PNG { get; set; }
        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<User, UserListModel>()
                .ForMember(x => x.FullName, cfg => cfg.MapFrom(x => x.Name + " " + x.Surname))
                .ForMember(x => x.NumberOfPosts, cfg => cfg.MapFrom(x => x.Posts.Count));
        }
    }
}
