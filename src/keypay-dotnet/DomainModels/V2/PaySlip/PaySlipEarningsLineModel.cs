namespace KeyPay.DomainModels.V2.PaySlip
{
    public class PaySlipEarningsLineModel
    {
        public string PayCategoryName { get; set; }
        public decimal Units { get; set; }
        public bool IsFixed { get; set; }
        public bool IsTaxExempt { get; set; }
        public decimal Rate { get; set; }
        public decimal SuperContribution { get; set; }
        public string Notes { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
    }
}