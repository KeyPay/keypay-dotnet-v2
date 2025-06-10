using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkOccupationalAbsenceModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveCategoryTypeEnum LeaveCategoryType { get; set; }
        public int? LeaveCategoryId { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public bool IsReadOnly { get; set; }
        public bool HalfDayFirstDay { get; set; }
        public bool HalfDayLastDay { get; set; }
        public decimal Amount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public OccupationalBasicPayAdjustmentTypeEnum? BasicPayAdjustmentType { get; set; }
        public decimal UnpaidDays { get; set; }
        public decimal SickDays { get; set; }
        public bool OverrideAmount { get; set; }
        public decimal? AmountOverride { get; set; }
        public int? ReportingTagId { get; set; }
        public string ReportingTagName { get; set; }
        public string Notes { get; set; }
        public IList<UkOccupationalAbsenceAttachmentModel> Attachments { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StatutoryPaymentStatus Status { get; set; }
        public string StatusDescription { get; set; }
        public bool OverrideServiceBand { get; set; }
        public int? OverriddenServiceBandId { get; set; }
        public bool MaximumEntitlementReached { get; set; }
        public bool EntitlementFullyExhausted { get; set; }
    }
}
