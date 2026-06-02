using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class MyPayRunTotalDetailModel
    {
        public decimal EpfEmployerAmount { get; set; }
        public decimal EpfEmployeeAmount { get; set; }
        public decimal EisEmployerAmount { get; set; }
        public decimal EisEmployeeAmount { get; set; }
        public decimal SocsoEmployerAmount { get; set; }
        public decimal SocsoEmployeeAmount { get; set; }
        public decimal SocsoSkbbkEmployeeAmount { get; set; }
        public decimal HrdfAmount { get; set; }
        public decimal Cp38Amount { get; set; }
        public decimal PcbBorneByEmployerAmount { get; set; }
        public decimal BikTaxableAmount { get; set; }
        public decimal BikTaxExemptAmount { get; set; }
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
