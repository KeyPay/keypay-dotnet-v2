using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkDetailedActivityReportExportModel
    {
        public decimal Paye { get; set; }
        public decimal StudentLoan { get; set; }
        public decimal EmployerNic { get; set; }
        public decimal EmployeeNic { get; set; }
        public decimal EmployerPension { get; set; }
        public decimal EmployeePension { get; set; }
        public decimal GrossPlusPensions { get; set; }
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
