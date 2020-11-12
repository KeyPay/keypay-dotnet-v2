using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class NzGrossToNetResponseModel
    {
        public decimal Paye { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal StudentLoanMandatory { get; set; }
        public decimal StudentLoanVoluntary { get; set; }
        public decimal KiwiSaverEmployee { get; set; }
        public decimal KiwiSaverEmployer { get; set; }
        public decimal Esct { get; set; }
        public decimal TotalGrossPlusKiwiSaver { get; set; }
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
        public decimal TaxableEarnings { get; set; }
        public Dictionary<String,Decimal> PostTaxDeductions { get; set; }
        public decimal TotalPostTaxDeductions { get; set; }
        public Dictionary<String,Decimal> Expenses { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal BankPayments { get; set; }
    }
}
