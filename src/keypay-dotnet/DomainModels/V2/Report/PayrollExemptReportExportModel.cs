using System;

namespace KeyPay.DomainModels.V2.Report
{
    public class PayrollExemptReportExportModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal SuperContributions { get; set; }
        public string LocationName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}