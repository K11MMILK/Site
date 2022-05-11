using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entities
{
    public class Page
    {
#pragma warning disable CS8618
        public ushort Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Status { get; set; }
        public string PNG { get; set; }
        public Page() { }
        public Page(string name, string surname) 
        {
            Name = name;
            Surname = surname;
            Age = 1;
            Status = " ";
            }
        

    }
}