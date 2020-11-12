using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class AuPayRunTotalDetailModel
    {
        public decimal PaygWithholdingAmount { get; set; }
        public decimal PaygWithholdingPercent { get; set; }
        public decimal SfssAmount { get; set; }
        public decimal HelpAmount { get; set; }
        public decimal SuperContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal SuperContributionMinusSuperAdjustments { get; set; }
        public decimal AllSuperContributionsTotal { get; set; }
        public decimal GrossPlusSuper { get; set; }
        public decimal SuperAdjustmentsAmount { get; set; }
        public decimal SalarySacrificeSuperAmount { get; set; }
        public decimal MemberVoluntarySuperAmount { get; set; }
        public decimal NonSuperDeductionTotal { get; set; }
        public decimal SuperPaymentsTotal { get; set; }
        public bool IsEmployeeUnder18 { get; set; }
        public decimal EmployerContributionAdjustmentsAmount { get; set; }
        public decimal PaygAdjustmentsAmount { get; set; }
        public bool SuperContributionsCapApplied { get; set; }
        public decimal PaygPaymentTotal { get; set; }
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public decimal TotalHours { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal PostTaxDeductionAmount { get; set; }
        public decimal PreTaxDeductionAmount { get; set; }
        public string PayConditionRuleSetName { get; set; }
        public int EmployeeId { get; set; }
        public bool IsTermination { get; set; }
        public string Notation { get; set; }
        public DateTime? EmployeeStartDate { get; set; }
        public string EmployeeExternalReferenceId { get; set; }
        public bool IsExcluded { get; set; }
        public string EmployeeExternalId { get; set; }
        public decimal BankPaymentsTotal { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? EarliestTerminationDate { get; set; }
        public DateTime? PreviousTerminationDate { get; set; }
        public decimal EmployeeExpensesTotal { get; set; }
        public decimal EmployerLiabilitiesTotal { get; set; }
        public bool IsComplete { get; set; }
    }
}
