using System;

namespace KeyPay.DomainModels.V2.Report
{
    public class PaymentHistoryReportExportModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public DateTime DatePaid { get; set; }
        public string LocationName { get; set; }
        public string AccountName { get; set; }
        public string BSB { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TotalAllowances { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal Amount { get; set; }
    }
}