using First_site_V2.Storage.Configurations;
using First_site_V2.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace First_site_V2.Storage
{
    public class GaisContext : DbContext
    {
        public GaisContext(DbContextOptions<GaisContext> options) : base(options)
        {
            //People.Add(new Profile("aaa", "Vasileva", "potata", "Voloshenko", "https://html5book.ru/wp-content/uploads/2017/08/pastel-rose.jpg"));
            //People.Add(new Profile("bogdan", "bogomdan", "p3nn15", "Bogdan", "https://cdn1.flamp.ru/75fabf2654ec6a76b0c40b6118977fe7_300_300.jpg"));
            //People.Add(new Profile("Kroll", "Barista", "Mudila", "Barista", "https://sun9-49.userapi.com/s/v1/if1/hsfWYGA57fkAdtUIq9lhgbTaIo-SqT8LTJlhAVW78LhDGx7M1hPMkYr3KSqFgXIamdIBEw6Y.jpg?size=1440x2160&quality=96&type=album"));
            //People.Add(new Profile("SA10", "Hikka", "Animechnik", "Huesos", "https://i27.fastpic.org/big/2011/1202/1f/792f1793f9d0ef625dc458a422904e1f.png"));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFriend> Friends { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new FriendRequestConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
