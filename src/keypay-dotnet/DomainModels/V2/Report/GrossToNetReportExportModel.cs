using System.Collections.Generic;
using System.Linq;

namespace KeyPay.DomainModels.V2.Report
{
    public class GrossToNetReportExportModel
    {
        public GrossToNetReportExportModel()
        {
            GrossEarnings = new Dictionary<string, decimal>();
            PreTaxDeductions = new Dictionary<string, decimal>();
            PostTaxDeductions = new Dictionary<string, decimal>();
            Expenses = new Dictionary<string, decimal>();
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int PrimaryLocationId { get; set; }
        public string PrimaryLocation { get; set; }
        public string ExternalId { get; set; }
        public decimal TotalHours { get; set; }
        public Dictionary<string, decimal> GrossEarnings { get; set; }
        public decimal TotalGrossEarnings => GrossEarnings.Values.Sum();
        public decimal TotalTaxExemptEarnings { get; set; }
        public Dictionary<string, decimal> PreTaxDeductions { get; set; }
        public decimal TotalPreTaxDeductions => PreTaxDeductions.Values.Sum();
        public decimal TaxableEarnings => TotalGrossEarnings - TotalTaxExemptEarnings - TotalPreTaxDeductions;
        public decimal Payg { get; set; }
        public decimal Sfss { get; set; }
        public decimal Help { get; set; }
        public Dictionary<string, decimal> PostTaxDeductions { get; set; }
        public decimal TotalPostTaxDeductions => PostTaxDeductions.Values.Sum();
        public decimal NetEarnings => TaxableEarnings - Payg - Sfss - Help - TotalPostTaxDeductions;
        public Dictionary<string, decimal> Expenses { get; set; }
        public decimal TotalExpenses => Expenses.Values.Sum();
        public decimal BankPayments => NetEarnings + TotalExpenses;
        public decimal Sgc { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal TotalGrossPlusSuper => TotalGrossEarnings + Sgc + EmployerContribution;

    }
}