namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunTotalModel
    {
        public int PayRunId { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PostTaxDeductions { get; set; }
        public decimal PaygWithheld { get; set; }
        public decimal SfssWithheld { get; set; }
        public decimal HelpWithheld { get; set; }
        public decimal SuperContribution { get; set; }
        public decimal NetEarnings { get; set; }
        public string Notes { get; set; }
    }
}