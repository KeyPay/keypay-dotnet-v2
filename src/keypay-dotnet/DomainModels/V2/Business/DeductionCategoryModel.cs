namespace KeyPay.DomainModels.V2.Business
{
    public class DeductionCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool TaxExempt { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
        public string PaymentSummaryClassification { get; set; }
        public bool ExcludeFromSgcCalculations { get; set; }
    }
}