namespace BLL.Entities
{
    public class RelatedProduct
    {
        public int Id { get; set; }
        public int AgreementPositionId { get; set; }
        public string KTM { get; set; }
        public string Descriptor { get; set; }        
    }
}
