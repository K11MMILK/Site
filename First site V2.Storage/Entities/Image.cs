using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace First_site_V2.Storage.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string ImageURL { get; set; }
        
    }
}
