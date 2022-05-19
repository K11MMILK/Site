using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entities
{
    public class Community
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PNG { get; set; }
        public Community()
        {

        }
        public Community(string name, string png = "/css/community.png")
        {                            
            Name = name;
            PNG = png;

        }

    }
}
