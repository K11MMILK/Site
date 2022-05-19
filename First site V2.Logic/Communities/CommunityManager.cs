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
            Community community = context.Community.Find(communityId);
            person.CommunityId.Add(new Lint() { value = communityId });
            community.MembersId.Add(new Lint() { value = person.Id });
            community.MembersName.Add(new Lstring() { value = person.Name });
            community.MembersSurname.Add(new Lstring() { value = person.Surname });
            community.MembersPNG.Add(new Lstring() { value = person.PNG });
            context.People.Update(person);
            context.Community.Update(community);
            context.SaveChanges();
        }
        public Profile GetMember(string login)
        {
            return context.People.FirstOrDefault(x => x.Login == login);
        }
    }
}
