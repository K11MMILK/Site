using First_site_V2.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Context
{
    public class PageContext
    {

        public Page human;/* { get; set; }*//*= new Page( "Klim","Vasilev","K11M","https://www.motardinn.com/f/13775/137752519/klim-revolt.jpg");*/
        public PageContext()
        {
            human =new Page("Klim", "Vasilev", "K11M", "https://www.motardinn.com/f/13775/137752519/klim-revolt.jpg");
        }
    }

}
