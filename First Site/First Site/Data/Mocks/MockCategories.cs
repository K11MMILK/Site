using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Site.Data.Interfaces;
using First_Site.Data.Models;

namespace First_Site.Data.Mocks
{
    public class MockCategories : IPageCategories
    {
        public IEnumerable<Categories> AllCategories
        {
            get
            {
                return new List<Categories>
                {
                    new Categories { categoryName="Человек"},
                    new Categories {categoryName="Дог"},
                    new Categories { categoryName = "Кот" }
                };
            }
        }
    }
}
