using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Context
{
    public class ProfileContext
    {
        public List<Profile> People= new List<Profile> { };
        public ProfileContext()
        {

            //People.Add(new Profile(1, "Klim", "Vasilev", "K11M", "vasilev"));
            //People.Add(new Profile(2, "aaa", "Vasileva", "potata", "https://html5book.ru/wp-content/uploads/2017/08/pastel-rose.jpg"));
            //People.Add(new Profile(3, "bogdan", "bogomdan", "p3nn15", "https://cdn1.flamp.ru/75fabf2654ec6a76b0c40b6118977fe7_300_300.jpg"));
            //People.Add(new Profile(4, "Kroll", "Barista", "Mudila", "https://sun9-49.userapi.com/s/v1/if1/hsfWYGA57fkAdtUIq9lhgbTaIo-SqT8LTJlhAVW78LhDGx7M1hPMkYr3KSqFgXIamdIBEw6Y.jpg?size=1440x2160&quality=96&type=album"));
            //People.Add(new Profile(5, "SA10", "Hikka", "Animechnik", "https://i27.fastpic.org/big/2011/1202/1f/792f1793f9d0ef625dc458a422904e1f.png"));
            //People[0].Friends.Add(People[1]);
            //People[0].Friends.Add(People[2]);
            //People[0].Friends.Add(People[3]);
            //People[0].Friends.Add(People[4]);


        }

    }

}
