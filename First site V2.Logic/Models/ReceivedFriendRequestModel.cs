using AutoMapper;
using First_site_V2.Logic.Mapping;
using First_site_V2.Storage.Entities;
using First_site_V2.Storage.Entities.Enums;

namespace First_site_V2.Logic.Models
{
    public class ReceivedFriendRequestModel : IMapFrom<FriendRequest>, IHaveCustomMapping
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderFullName { get; set; }
        public FriendRequestStatus FriendRequestStatus { get; set; }
        public object ReceiverFullName { get; internal set; }

        public void ConfigureMapping(Profile profile)
        {
           profile.CreateMap<FriendRequest, ReceivedFriendRequestModel>()
                .ForMember(f=>f.SenderFullName,cfg=>cfg.MapFrom(f=>f.Sender.FirstName+" "+f.Sender.LastName));
        }
    }
}
