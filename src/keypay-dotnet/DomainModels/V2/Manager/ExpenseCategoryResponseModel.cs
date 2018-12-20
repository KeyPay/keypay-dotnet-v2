namespace KeyPay.DomainModels.V2.Manager
{
    public class ExpenseCategoryResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalTaxCodeId { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxRate { get; set; }
    }
}
