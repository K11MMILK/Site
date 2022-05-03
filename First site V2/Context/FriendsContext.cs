using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Context
{
    public class FriendsContext:ProfileContext
    {
        public FriendsContext()
        {
            human1.Friends.Add(human2);
            human2.Friends.Add(human1);

        }
    }
}
