using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class PayRunFinaliseDefaultSettingsModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference ExportJournals { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionTimeline ExportJournalsTimeline { get; set; }
        public int ExportJournalsDay { get; set; }
        public TimeSpan? ExportJournalsTimeOfDay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference LodgePayRun { get; set; }
        public int LodgePayRunDay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionTimeline LodgePayRunTimeline { get; set; }
        public TimeSpan? LodgePayRunTimeOfDay { get; set; }
        public int PublishPaySlipsDay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionTimeline PublishPaySlipsTimeline { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference PublishPaySlips { get; set; }
        public TimeSpan? PublishPaySlipsTimeOfDay { get; set; }
        public bool SuppressNotifications { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference SubmitToPensionSync { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionTimeline SubmitToPensionSyncTimeline { get; set; }
        public int SubmitToPensionSyncDay { get; set; }
        public TimeSpan? SubmitToPensionSyncTimeOfDay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference RunReportPacks { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionTimeline RunReportPacksTimeline { get; set; }
        public int RunReportPacksDay { get; set; }
        public TimeSpan? RunReportPacksTimeOfDay { get; set; }
        public List<Int32> ReportPacksToRun { get; set; }
        public bool SuperPayment { get; set; }
    }
}
