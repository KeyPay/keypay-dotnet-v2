namespace KeyPay.DomainModels.V2.Report
{
    public class DetailedActivityReportExportModel
    {
        public int EmployeeId { get; set; }
        public string Location { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public decimal Hours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal TaxExemptEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal Payg { get; set; }
        public decimal Sfss { get; set; }
        public decimal Help { get; set; }
        public decimal Super { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal GrossPlusSuper { get; set; }

    }
}