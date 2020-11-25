using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.EmployeeRecurringTransactions
{
    public class EmployeeRecurringDeductionModel
    {
        public string Name { get; set; }
        public int DeductionCategoryId { get; set; }
        public EmployeeRecurringDeductionPaidToEnum PaidTo { get; set; }
        public int PaidToAccountId { get; set; }
        public string ExternalReferenceId { get; set; }
        public DeductionAmountNotReachedEnum PreservedEarningsAmountNotReachedAction { get; set; }
        public bool CarryForwardUnpaidDeductions { get; set; }
        public bool CarryForwardUnusedPreservedEarnings { get; set; }
        public string PaymentReference { get; set; }
        public DeductionTypeEnum DeductionType { get; set; }
        public PreservedEarningsCalculationTypeEnum PreservedEarnings { get; set; }
        public decimal PreservedEarningsAmount { get; set; }
        public int? AdditionalData { get; set; }
        public int? Priority { get; set; }
        public StudentLoanDeductionOption? StudentLoanDeductionOption { get; set; }
        public int? TieredDeductionSettingsId { get; set; }
        public bool Deleted { get; set; }
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? MaximumAmountPaid { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
    }
}
