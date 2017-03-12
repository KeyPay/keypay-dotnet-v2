namespace KeyPay.DomainModels.V2.PayRun
{
    public class PayRunGrandTotalModel
    {
        public decimal TotalHours { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal PaygWithholdingAmount { get; set; }
        public decimal SFSSAmount { get; set; }
        public decimal HelpAmount { get; set; }
        public decimal SuperContribution { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal EmployeeExpensesTotal { get; set; }
        public decimal EmployerLiabilitiesTotal { get; set; }
    }
}