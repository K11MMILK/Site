using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Site.Data.Models
{
    public class Categories
    {
        public int id { set; get; }
        public string categoryName { set; get; }

        //ввв
        public List<Page> pages{ set; get; }
    }
}
