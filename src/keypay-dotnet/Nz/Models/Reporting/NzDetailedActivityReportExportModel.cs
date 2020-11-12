using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class NzDetailedActivityReportExportModel
    {
        public decimal Paye { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal StudentLoanVoluntaryAmount { get; set; }
        public decimal StudentLoanMandatoryAmount { get; set; }
        public decimal KiwiSaverEmployeeContributionAmount { get; set; }
        public decimal KiwiSaverEmployerContributionAmount { get; set; }
        public decimal EsctContributionAmount { get; set; }
        public decimal GrossPlusKiwiSaver { get; set; }
        public string Location { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public decimal Hours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public Object PostTaxDeductions { get; set; }
        public decimal TaxExemptEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal EmployerLiabilities { get; set; }
    }
}
