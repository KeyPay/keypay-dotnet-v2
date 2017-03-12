namespace KeyPay.DomainModels.V2.Report
{
    public class SuperContributionsReportExportModel
    {
        public string LocationName { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string SuperFundName { get; set; }
        public string SuperFundNumber { get; set; }
        public string PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}