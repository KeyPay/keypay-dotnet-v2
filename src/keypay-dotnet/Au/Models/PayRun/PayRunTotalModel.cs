using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class PayRunTotalModel
    {
        public string Notes { get; set; }
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
        public decimal CpfEmployerContributionAmount { get; set; }
        public decimal CpfEmployeeContributionAmount { get; set; }
        public decimal EmployerVoluntaryCpfAmount { get; set; }
        public decimal EmployerVoluntaryMediSaveAmount { get; set; }
        public decimal SdlContributionAmount { get; set; }
        public decimal EmployerPensionContribution { get; set; }
        public decimal EmployeePensionContribution { get; set; }
        public decimal EmployeeNationalInsuranceContribution { get; set; }
        public decimal EmployerNationalInsuranceContribution { get; set; }
        public decimal EmployeePensionableEarnings { get; set; }
        public decimal EmployerPensionableEarnings { get; set; }
        public decimal? TerminationPaymentNIExempt { get; set; }
        public decimal? TerminationPaymentEmployerNI { get; set; }
        public decimal? NicClass1A { get; set; }
        public bool? EnrolledInPensionScheme { get; set; }
        public DateTime? DeferralDate { get; set; }
        public decimal BikTaxableAmount { get; set; }
        public decimal BikTaxExemptAmount { get; set; }
        public decimal Cp38Amount { get; set; }
        public decimal PcbBorneByEmployerAmount { get; set; }
        public decimal EpfEmployerAmount { get; set; }
        public decimal EpfEmployeeAmount { get; set; }
        public decimal EisEmployerAmount { get; set; }
        public decimal EisEmployeeAmount { get; set; }
        public decimal SocsoEmployerAmount { get; set; }
        public decimal SocsoEmployeeAmount { get; set; }
        public decimal HrdfAmount { get; set; }
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
        public string Notation { get; set; }
    }
}
