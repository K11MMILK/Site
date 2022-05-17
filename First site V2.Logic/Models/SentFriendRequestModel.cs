using AutoMapper;
using First_site_V2.Logic.Mapping;
using First_site_V2.Storage.Entities;
using First_site_V2.Storage.Entities.Enums;

namespace First_site_V2.Logic.Models
{
    public class SentFriendRequestModel : IMapFrom<FriendRequest>, IHaveCustomMapping
    {
        public int Id { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverFullName { get; set; }
        public FriendRequestStatus FriendRequestStatus { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<FriendRequest, ReceivedFriendRequestModel>()
                .ForMember(f => f.ReceiverFullName, cfg => cfg.MapFrom(f => f.Receiver.FirstName + " " + f.Receiver.LastName));
        }
    }
}
