using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entity
{
    public class Page
    {
        public ushort age { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string status { get; set; }
        public string png { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Page() { }
        public Page(string login, string password, string name, string surname) 
        { 
            this.password = password;
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = 1;
            status = " ";
            png = "~css/i.png";
        }
        

    }
}