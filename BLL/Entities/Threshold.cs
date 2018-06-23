using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Threshold
    {
        public int Id { get; set; }
        public int AmountFrom { get; set; }
        public int AmountTo { get; set; }
        public double LicenseFeePercentage { get; set; }
        public double AmountPerCopy { get; set; }
    }
}
