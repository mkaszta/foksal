using System;

namespace BLL.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SqlViewName { get; set; }
        public string SqlOrderBy { get; set; }
    }
}
