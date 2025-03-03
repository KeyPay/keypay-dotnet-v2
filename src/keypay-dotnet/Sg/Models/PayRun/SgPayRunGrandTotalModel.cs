using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SgPayRunGrandTotalModel
    {
        public decimal CpfEmployerContributionAmount { get; set; }
        public decimal CpfEmployeeContributionAmount { get; set; }
        public decimal EmployerVoluntaryCpfAmount { get; set; }
        public decimal EmployerVoluntaryMediSaveAmount { get; set; }
        public decimal SdlContributionAmount { get; set; }
        public decimal WithholdingTaxAmount { get; set; }
        public decimal ClearanceTaxAmount { get; set; }
        public int NumberOfEmployees { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal EmployeeExpensesTotal { get; set; }
        public decimal EmployerLiabilitiesTotal { get; set; }
    }
}
