namespace KeyPay.DomainModels.V2.Report
{
    public class PayrollTaxReportExportModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public decimal Amount { get; set; }
        public bool EmployeePayrollTaxExempt { get; set; }
        public bool PayCategoryPayrollTaxExempt { get; set; }
        public bool TerminationPayment { get; set; }
        public bool Allowance { get; set; }
        public bool Etp { get; set; }
        public bool GenuineRedundancy { get; set; }
        public bool LumpSumD { get; set; }
    }
}