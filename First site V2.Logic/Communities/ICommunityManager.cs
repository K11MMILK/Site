using First_site_V2.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_site_V2.Logic.Communities
{
    public interface ICommunityManager
    {
        public ICollection<Community> GetAll();
        public Community GetCommunity(int id);
        public Community GetCommunity(string name);
        public int CreateCommunity(string CommunityName);
        public void JoinToCommunity(int MemberId, int CommunityId);
        public Profile GetMember(string login);
        public ICollection<Profile> GetAllMembers(int communityId);
        public void AddNewPost(int CommunityId, string textPost, string png);
        public ICollection<Post> GetAllPosts(int communityId);
    }
}
