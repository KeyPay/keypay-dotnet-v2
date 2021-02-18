using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class HmrcPaymentReminder
    {
        public bool? Enabled { get; set; }
        public string Recipients { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentReminderPeriod? Period { get; set; }
        public int? ReminderDay { get; set; }
        public bool? MonthlyBreakdown { get; set; }
        public bool? PayRunPensionAmounts { get; set; }
    }
}
