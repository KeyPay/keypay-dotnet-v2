using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgGrossToNetResponseModel
    {
        public decimal NetEarnings { get; set; }
        public decimal WithholdingTax { get; set; }
        public decimal ClearanceTax { get; set; }
        public decimal CpfEmployer { get; set; }
        public decimal CpfEmployee { get; set; }
        public decimal EmployerVoluntaryCpf { get; set; }
        public decimal EmployerVoluntaryMediSave { get; set; }
        public decimal TotalGrossPlusContributions { get; set; }
        public decimal TotalWithheld { get; set; }
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
