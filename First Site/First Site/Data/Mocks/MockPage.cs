using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Site.Data.Interfaces;
using First_Site.Data.Models;

namespace First_Site.Data.Mocks
{
    public class MockPage : IAllPages
    {

        private readonly IPageCategories categoryPage = new MockCategories();
        public IEnumerable<Page> AllPages
        { 
        
            get
            {
                return new List<Page>
                {
                    new Page
                    {
                        name="Klim",
                        surname="Vasilev",
                        status="K11M",
                        longDesc="Klim Klimushka",
                        png="https://www.motardinn.com/f/13775/137752519/klim-revolt.jpg",
                        Category= categoryPage.AllCategories.First()
                    },
                    new Page
                    {
                        name="Mila",
                        surname="Voloshenko",
                        status="Potato",
                        longDesc="Milaya devochka",
                        png="https://legkovmeste.ru/wp-content/uploads/2019/03/post_5baf7d26c155c.jpg",
                        Category=categoryPage.AllCategories.Last()
                    }
                };
            }

        }

        public Page getObjectPage(int pageID)
        {
            throw new NotImplementedException();
        }
    }
}
