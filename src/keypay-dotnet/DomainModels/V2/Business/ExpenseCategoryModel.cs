namespace KeyPay.DomainModels.V2.Business
{
    public class ExpenseCategoryModel
    {
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Description { get; set; }
        public string ExternalReferenceId { get; set; }
        public string ExternalTaxCodeId { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxRate { get; set; }
    }
}