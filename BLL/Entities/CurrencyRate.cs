using System;

namespace BLL.Entities
{
    public class CurrencyRate
    {
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        public DateTime Date { get; set; }
        public decimal Rate { get; set; }
    }
}
