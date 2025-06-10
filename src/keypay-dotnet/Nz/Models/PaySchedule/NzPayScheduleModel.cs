using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PaySchedule
{
    public class NzPayScheduleModel
    {
        public NzAutoPayConfigurationModel AutoPayConfiguration { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NzPayCycleFrequencyEnum Frequency { get; set; }
        public PayScheduleApprovalSettingsModel PaySchedulePaymentApprovalSettings { get; set; }
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
