using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entity
{
    public class Profile:Page
    {
        List<Music> Musics { get; set; }

        List<Video> Videos { get; set; }

        List<Community> Communities { get; set; }

        public Profile(string name, string surname, string status, string png, List<Music> musics, List<Video> videos, List<Community> communities):base(name, surname, status, png) {
            Musics = musics;
            Videos = videos;
            Communities = communities;
        }
    }
}
