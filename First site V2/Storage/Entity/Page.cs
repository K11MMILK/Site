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
            this.login = login;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.age = 1;
            status = " ";
            png = "https://sun9-27.userapi.com/s/v1/ig2/un-BopFJgNcU-iy3esL4JLNdI7QmjxJ3DEGxkksx8rD-ja9O2oqtpiaH5hEby_OvKIljdw8lAijwFHpyWi3eJjkB.jpg?size=320x320&quality=96&type=album";
        }
        

    }
}