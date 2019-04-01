using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class PayCategoryModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public RateUnit RateUnit { get; set; }
        public bool AccruesLeave { get; set; }
        public decimal DefaultSuperRate { get; set; }
        public decimal RateLoadingPercent { get; set; }
        public decimal PenaltyLoadingPercent { get; set; }
        public bool IsTaxExempt { get; set; }
        public bool IsPayrollTaxExempt { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public string GeneralLedgerMappingCode { get; set; }
        public string PaymentSummaryClassification { get; set; }
        public string SuperExpenseMappingCode { get; set; }
        public string SuperLiabilityMappingCode { get; set; }
        public bool IsSystemPayCategory { get; set; }
        public int? NumberOfDecimalPlaces { get; set; }
    }
}