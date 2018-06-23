using System;

namespace BLL.Entities
{
    public class Licensor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public bool IsNaturalPerson { get; set; }
        public DateTime? CertificateDate { get; set; }
        public decimal TaxPercentage { get; set; }        
        public decimal? VAT { get; set; }
        public string Email { get; set; }
        public DateTime EditedDate { get; set; }
        public int EditedBy { get; set; }
    }
}
