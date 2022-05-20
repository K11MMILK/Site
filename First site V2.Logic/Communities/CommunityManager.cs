using First_site_V2.Storage;
using First_site_V2.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_site_V2.Logic.Communities
{
    public class CommunityManager : ICommunityManager
    {
        public GaisContext context;
        public CommunityManager(GaisContext _context)
        {
            context = _context;
        }
        public int CreateCommunity(string CommunityName)
        {
            context.Community.Add(new Community(CommunityName));
            context.SaveChanges();
            return context.Community.FirstOrDefault(c=>c.Name==CommunityName).Id;
        }

        public ICollection<Community> GetAll()
        {
            return context.Community.ToList();
        }

        public Community GetCommunity(int id)
        {
            return context.Community.Find(id);
        }

        public Community GetCommunity(string name)
        {
            return context.Community.FirstOrDefault(x => x.Name == name);
        }

        public void JoinToCommunity(int MemberId, int communityId)
        {
            Profile person = context.People.Find(MemberId);
            person.CommunityId = communityId;
            context.People.Update(person);
            context.SaveChanges();
        }
        public Profile GetMember(string login)
        {
            return context.People.FirstOrDefault(x => x.Login == login);
        }
        public ICollection<Profile> GetAllMembers(int communityId)
        {
            List<Profile> members = new List<Profile>();
            foreach(var member in context.People)
            {
                if(member.CommunityId == communityId)
                    members.Add(member);
            }
            return members;
        }

        public void AddNewPost(int CommunityId, string textPost, string png)
        {            
            if(png != null)
                context.Posts.Add(new Post(CommunityId, textPost) { PNG = png });
            else
                context.Posts.Add(new Post(CommunityId, textPost));
            context.Community.Find(CommunityId).HasPosts = true;
            context.SaveChanges();
        }

        public ICollection<Post> GetAllPosts(int communityId)
        {
            List<Post> posts = new List<Post>();
            foreach(var post in context.Posts)
            {
                if(post.CommunityId==communityId)
                    posts.Add(post);
            }
            return posts;
        }
    }
}
