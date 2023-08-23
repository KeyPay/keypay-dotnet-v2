using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkStatutorySickLeaveModel
    {
        public int Id { get; set; }
        public int? WaitingDaysUsed { get; set; }
        public int? WaitingDaysUsedOverride { get; set; }
        public bool OverrideWaitingDaysUsed { get; set; }
        public int QualifyingDays { get; set; }
        public bool QualifiesForSsp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryType? StatutoryPayCategoryType { get; set; }
        public bool DoNotPay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DoNotPaySspReasonEnum? DoNotPayReason { get; set; }
        public WeekModel Week1 { get; set; }
        public WeekModel Week2 { get; set; }
        public bool ShowWeek2 { get; set; }
        public bool OverrideAverageWeeklyEarnings { get; set; }
        public decimal? AverageWeeklyEarningsOverride { get; set; }
        public decimal? Amount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StatutoryPaymentStatus? Status { get; set; }
        public string StatusDescription { get; set; }
        public decimal? AverageWeeklyEarnings { get; set; }
        public bool IsCalculated { get; set; }
        public UkStatutorySickLeaveAttachmentModel[] Attachments { get; set; }
        public string Notes { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BasicPayAdjustmentTypeEnum? BasicPayAdjustmentType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SspCalculationStatusEnum? CalculationStatus { get; set; }
        public bool ShowSsp1Warning { get; set; }
        public bool IsReadOnly { get; set; }
        public decimal? MaximumOffsetDays { get; set; }
    }
}
