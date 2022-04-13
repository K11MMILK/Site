using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Site.Data.Models;
namespace First_Site.Data.Interfaces
{
    interface IAllPages
    {

        IEnumerable<Page> AllPages { get; }
        Page getObjectPage(int pageID);

    }
}
