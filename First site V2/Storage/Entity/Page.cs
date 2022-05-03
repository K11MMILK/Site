using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entity
{
    public class Page
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string status { get; set; }
        public string png { get; set; }
        public Page (int id, string name, string surname, string status, string png) {
            this.id = id;
            this.name = name; 
            this.surname = surname;
            this.status = status;
            this.png = png; 
        }

    }
}