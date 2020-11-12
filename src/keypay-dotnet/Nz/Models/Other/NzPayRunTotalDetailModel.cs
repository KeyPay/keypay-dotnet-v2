using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class NzPayRunTotalDetailModel
    {
        public decimal PayeWithholdingAmount { get; set; }
        public decimal PayeWithholdingPercentage { get; set; }
        public decimal PayeAdjustmentsAmount { get; set; }
        public decimal PayePaymentTotal { get; set; }
        public decimal StudentLoanAmount { get; set; }
        public decimal KiwiSaverEmployerContributionAmount { get; set; }
        public decimal KiwiSaverEmployeeContributionAmount { get; set; }
        public decimal EsctContributionAmount { get; set; }
        public decimal StudentLoanAdditionalMandatoryAmount { get; set; }
        public decimal StudentLoanAdditionalVoluntaryAmount { get; set; }
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
