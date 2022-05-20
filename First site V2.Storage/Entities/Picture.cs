using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_site_V2.Storage.Entities
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        
        public int UserId { get; set; }
        public string Imagin { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual Profile User { get; set; }
        
    }
}
