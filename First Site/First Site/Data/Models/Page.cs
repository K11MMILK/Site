using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Site.Data.Models
{
    public class Page
    {

        public int id { set; get; }
        public string name { set; get; }
        public string surname { set; get; }

        public string status{ set; get; }

        public string longDesc{ set; get; }

        public string png { set; get; }

        //public ushort FriendsCount { set; get; }
        //public ushort PhotoCount{ set; get; }
        //public ushort VideoCount{ set; get; }
        //public ushort AudioCount{ set; get; }
        //public List<string> AllPhotos { set; get; }
        //public List<string> AllVideos { set; get; }
        //public List<string> AllMusic  { set; get; }

        public int categoryID { set; get; }

        public virtual Categories Category { get; set; }
    }
}
