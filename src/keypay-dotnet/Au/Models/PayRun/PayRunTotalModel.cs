using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.PayRun
{
    public class PayRunTotalModel
    {
        public int Id { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PostTaxDeductions { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TotalEmployeeExpenses { get; set; }
        public decimal TotalEmployerLiabilities { get; set; }
        public bool IsPublished { get; set; }
        public int PayRunId { get; set; }
        public string Notes { get; set; }
        public string Notation { get; set; }
        public decimal PaygWithheld { get; set; }
        public decimal SfssWithheld { get; set; }
        public decimal HelpWithheld { get; set; }
        public decimal SuperContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal KiwiSaverEmployeeContribution { get; set; }
        public decimal KiwiSaverEmployerContribution { get; set; }
        public decimal EsctContribution { get; set; }
        public decimal StudentLoanAmount { get; set; }
        public decimal PostGradLoanAmount { get; set; }
        public decimal StudentLoanAdditionalMandatoryAmount { get; set; }
        public decimal StudentLoanAdditionalVoluntaryAmount { get; set; }
        public decimal AccLevyAmount { get; set; }
        public decimal EmployerPensionContribution { get; set; }
        public decimal EmployeePensionContribution { get; set; }
        public decimal EmployeeNationalInsuranceContribution { get; set; }
        public decimal EmployerNationalInsuranceContribution { get; set; }
        public decimal EmployeePensionableEarnings { get; set; }
        public decimal EmployerPensionableEarnings { get; set; }
        public decimal CpfEmployerContributionAmount { get; set; }
        public decimal CpfEmployeeContributionAmount { get; set; }
        public decimal EmployerVoluntaryCpfAmount { get; set; }
        public decimal EmployerVoluntaryMediSaveAmount { get; set; }
        public decimal SdlContributionAmount { get; set; }
    }
}
