using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string PostText { get; set; }
        public string PNG { get; set; }
        public int CommunityId { get; set; }
        [ForeignKey(nameof(CommunityId))]
        public virtual Community community { get; set; }
        public Post() { }
        public Post(int communityId, string postText)
        {
            CommunityId = communityId;
            PostText = postText;
            PNG = "/css/klim-revolt.jpg";
        }
    }
}
