using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class MyDetailedActivityReportExportModel
    {
        public decimal Payg { get; set; }
        public decimal Cp38Amount { get; set; }
        public decimal EmployerEpfAmount { get; set; }
        public decimal EmployeeEpfAmount { get; set; }
        public decimal EmployeeEisAmount { get; set; }
        public decimal EmployerEisAmount { get; set; }
        public decimal EmployeeSocsoAmount { get; set; }
        public decimal EmployerSocsoAmount { get; set; }
        public decimal HrdfAmount { get; set; }
        public decimal ZakatAmount { get; set; }
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
