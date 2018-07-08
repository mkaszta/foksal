namespace BLL.Entities
{
    public class RelatedArticle
    {
        public int Id { get; set; }
        public int AgreementId { get; set; }
        public string KTM { get; set; }
        public string Descriptor { get; set; }
        public string Comments { get; set; }
    }
}
