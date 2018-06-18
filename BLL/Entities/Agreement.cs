using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Agreement
    {
        public int AgreementID { get; set; }
        public string ReportTitle { get; set; }
        public string ReportAuthor { get; set; }
        public string Title { get; set; }
        public double Advance { get; set; }
        public DateTime? AdvanceDate { get; set; }
        public string Comments { get; set; }
        public DateTime? EditedDate { get; set; }
        public int EditetBy { get; set; }
    }
}
