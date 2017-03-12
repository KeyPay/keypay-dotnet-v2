namespace KeyPay.DomainModels.V2.Report
{
    public class ActivityReportExportModel
    {
        public int EmployeeId { get; set; }
        public int LocationId { get; set; }
        public string Location { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PaygWithholding { get; set; }
        public decimal SuperContributions { get; set; }
        public decimal NetEarnings { get; set; }
    }
}