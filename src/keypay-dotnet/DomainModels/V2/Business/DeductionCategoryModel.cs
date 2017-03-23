using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class DeductionCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool TaxExempt { get; set; }
        public string Source { get; set; }
        public string ExternalId { get; set; }
        public SGCCalculationImpact SGCCalculationImpact { get; set; }
        public string PaymentSummaryClassification { get; set; }
        public string ExpenseGeneralLedgerMappingCode { get; set; }
        public string LiabilityGeneralLedgerMappingCode { get; set; }
    }
}