using System.ComponentModel.DataAnnotations;

namespace First_site_V2.Storage.Entities
{
    public class ReportOnUser
    {
        [Key]
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string SenderName { get; set; }
        public int RecieverId { get; set; }
        public string ReportText { get; set; }
    }
}
