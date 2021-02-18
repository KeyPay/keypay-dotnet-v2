using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class SapPayment
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WeekNumber { get; set; }
        public bool Include { get; set; }
        public bool OffsetSap { get; set; }
        public decimal? Amount { get; set; }
        public int? PayRunId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DoNotPaySapReasonEnum? DoNotPayReason { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public StatutoryAdoptionPaymentStatus? Status { get; set; }
        public string StatusDescription { get; set; }
        public int DaysPaid { get; set; }
        public bool IsPending { get; set; }
        public List<StatutoryLeaveDailyBreakdown> Breakdown { get; set; }
    }
}
