using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_site_V2.Storage.Entities
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string ReportText { get; set; }
        public Report(string reportText, string senderName)
        {
            ReportText = reportText;
            SenderName = senderName;
        }
    }
}
