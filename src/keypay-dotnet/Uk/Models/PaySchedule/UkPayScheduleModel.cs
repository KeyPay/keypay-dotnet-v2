using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class UkPayScheduleModel
    {
        public UkAutoPayConfigurationModel AutoPayConfiguration { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UkPayCycleFrequencyEnum Frequency { get; set; }
        public PayScheduleProRataSettingsModel PayScheduleProRataSettings { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunEmployeeSelectionStrategy? EmployeeSelectionStrategy { get; set; }
        public DateTime? LastDatePaid { get; set; }
        public DateTime? LastPayRun { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public List<Int32> Locations { get; set; }
        public bool EqualMonthlyPayments { get; set; }
        public List<Int32> IgnoredPayRunWarnings { get; set; }
        public PayRunFinaliseDefaultSettingsModel DefaultFinaliseSettings { get; set; }
        public PayScheduleApprovalSettingsModel PayScheduleApprovalSettings { get; set; }
    }
}
