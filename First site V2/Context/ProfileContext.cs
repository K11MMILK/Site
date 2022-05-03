using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Context
{
    public class ProfileContext
    {

        public Profile human1;
        public Profile human2;
        public ProfileContext()
        {
            human1 =new Profile(1, "Klim", "Vasilev", "K11M", "https://www.motardinn.com/f/13775/137752519/klim-revolt.jpg");
            human2 = new Profile(2, "aaa", "Vasileva", "potata", "https://html5book.ru/wp-content/uploads/2017/08/pastel-rose.jpg");
        }
    }

}
