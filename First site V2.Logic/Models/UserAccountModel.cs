using AutoMapper;
using First_site_V2.Logic.Mapping;
using First_site_V2.Storage.Entities;

namespace First_site_V2.Logic.Models
{
    public class UserAccountModel:IMapFrom<User>,IHaveCustomMapping
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte[] PNG { get; set; }
        public ICollection<UserListModel> Friends { get; set; } = new List<UserListModel> { };
        public ICollection<ReceivedFriendRequestModel> FreindRequestReceived { get; set; } = new List<ReceivedFriendRequestModel> { };
        public ICollection<SentFriendRequestModel> FreindRequestSent { get; set; } = new List<SentFriendRequestModel> { };

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<User, UserAccountModel>();
        }
    }
}
