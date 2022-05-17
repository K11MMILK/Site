using AutoMapper;
using First_site_V2.Logic.Mapping;
using First_site_V2.Storage.Entities;

namespace First_site_V2.Logic.Models
{
    public class UserAccountModel:IMapFrom<User>,IHaveCustomMapping
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; } = " ";
        public byte[] PNG { get; set; }
        public PaginatedList<PostModel> Posts { get; set; } = null;              //postmodel сделать
        public ICollection<UserListModel> Friends { get; set; } = new List<UserListModel> { };
        public ICollection<ReceivedFriendRequestModel> FreindRequestReceived { get; set; } = new List<ReceivedFriendRequestModel> { };
        public ICollection<SentFriendRequestModel> FreindRequestSent { get; set; } = new List<SentFriendRequestModel> { };

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<User, UserAccountModel>()
                .ForMember(u => u.Posts, cfg => cfg.Ignore())
                .ForMember(u => u.Friends, cfg => cfg.Ignore());
        }
    }
}
