using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class AuQualifyingEarningsReportExportModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DatePaid { get; set; }
        public string Location { get; set; }
        public string ExternalId { get; set; }
        public decimal Hours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal QualifyingEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal PostTaxDeductions { get; set; }
        public decimal TaxExemptEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal Payg { get; set; }
        public decimal SfssHelpStsl { get; set; }
        public decimal SgSuper { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal SuperPercentageOfQualifyingEarnings { get; set; }
    }
}
