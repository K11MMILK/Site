﻿using System;
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

        public List<Profile> Friends { get; set; }

        public Profile(int id, string name, string surname, string status, string png):base(id, name, surname, status, png) {
            Musics = new List<Music> { };
            Videos = new List<Video> { };
            Communities = new List<Community> { };
            Friends = new List<Profile> { };
        }
    }
}
