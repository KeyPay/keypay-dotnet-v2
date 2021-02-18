using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgDetailedActivityReportExportModel
    {
        public decimal WithheldAmount { get; set; }
        public decimal SdlContribution { get; set; }
        public decimal CpfEmployerContribution { get; set; }
        public decimal CpfEmployeeContribution { get; set; }
        public decimal VoluntaryEmployerContribution { get; set; }
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
