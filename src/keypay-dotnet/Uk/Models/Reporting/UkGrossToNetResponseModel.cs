using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkGrossToNetResponseModel
    {
        public decimal Paye { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal PostGradLoan { get; set; }
        public decimal EmployerPensionContribution { get; set; }
        public decimal EmployeePensionContribution { get; set; }
        public decimal EmployerNic { get; set; }
        public decimal EmployeeNic { get; set; }
        public decimal TotalGrossPlusPensions { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int PrimaryLocationId { get; set; }
        public string PrimaryLocation { get; set; }
        public string ExternalId { get; set; }
        public decimal TotalHours { get; set; }
        public Dictionary<String,Decimal> GrossEarnings { get; set; }
        public decimal TotalGrossEarnings { get; set; }
        public decimal TotalTaxExemptEarnings { get; set; }
        public Dictionary<String,Decimal> PreTaxDeductions { get; set; }
        public decimal TotalPreTaxDeductions { get; set; }
        public Dictionary<String,Decimal> PostTaxDeductions { get; set; }
        public decimal TotalPostTaxDeductions { get; set; }
        public Dictionary<String,Decimal> Expenses { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal BankPayments { get; set; }
    }
}
