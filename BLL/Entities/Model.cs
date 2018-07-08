using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasThresholds { get; set; }
        public bool IsPercent { get; set; }
        public bool IsActive { get; set; }
        public string LabelPercent { get; set; }
        public string LabelFixedPrice { get; set; }
    }
}
