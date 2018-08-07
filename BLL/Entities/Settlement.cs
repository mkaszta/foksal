using System;

namespace BLL.Entities
{
    public class Settlement
    {
        public int Id { get; set; }
        public DateTime GenerationDate { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string Email{ get; set; }
        public bool IsLocked { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? AmountToPayOut { get; set; }
        public string PurchaseOrder { get; set; }
        public string Comments { get; set; }
        public DateTime? CertificateDate { get; set; }
        public decimal TaxPercent { get; set; }
        public DateTime Period { get; set; }
    }
}
