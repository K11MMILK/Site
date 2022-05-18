using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace First_site_V2.Storage.Configurations
{
    internal class FriendRequestConfiguration : IEntityTypeConfiguration<FriendRequest>
    {
        public void Configure(EntityTypeBuilder<FriendRequest> builder)
        {
            builder
                .HasOne(fr => fr.Sender)
                .WithMany(u => u.FriendRequestSent)
                .HasForeignKey(fr => fr.SenderId);

            builder
               .HasOne(fr => fr.Receiver)
               .WithMany(u => u.FriendRequestReceived)
               .HasForeignKey(fr => fr.ReceiverId);
        }
    }
}