using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeRecurringTransactions
{
    public class EmployeeRecurringDeductionModel
    {
        public string Name { get; set; }
        public int DeductionCategoryId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeRecurringDeductionPaidToEnum PaidTo { get; set; }
        public int PaidToAccountId { get; set; }
        public string ExternalReferenceId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionAmountNotReachedEnum PreservedEarningsAmountNotReachedAction { get; set; }
        public bool CarryForwardUnpaidDeductions { get; set; }
        public bool CarryForwardUnusedPreservedEarnings { get; set; }
        public string PaymentReference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DeductionTypeEnum DeductionType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PreservedEarningsCalculationTypeEnum PreservedEarnings { get; set; }
        public decimal PreservedEarningsAmount { get; set; }
        public int? AdditionalData { get; set; }
        public int? Priority { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
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
