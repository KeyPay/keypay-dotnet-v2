using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class FinalisePayRunOptions
    {
        public int PayRunId { get; set; }
        public DateTime? DatePaid { get; set; }
        public bool ExportJournals { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PublishPaySlipsPreference PublishPaySlips { get; set; }
        public DateTime? PublishPaySlipsDateTime { get; set; }
        public bool SuppressNotifications { get; set; }
        public bool LodgePayRun { get; set; }
        public bool LodgePayRunInTestMode { get; set; }
        public bool SubmitToPensionSync { get; set; }
        public bool LodgeFinalPayRun { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public HmrcFpsLateSubmissionReason? RelodgeHmrcLateSubmissionReason { get; set; }
        public bool RelodgeSelectedEmployeesOnly { get; set; }
        public bool FinaliseAsAdmin { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference? PublishPaySlipsPreference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference? ExportJournalsPreference { get; set; }
        public DateTime? ExportJournalsDateTime { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference? LodgePayRunPreference { get; set; }
        public bool SuperPaymentPreference { get; set; }
        public DateTime? LodgePayRunDateTime { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference? RunReportPacksPreference { get; set; }
        public DateTime? RunReportPacksDateTime { get; set; }
        public List<Int32> ReportPacksToRun { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference? SubmitToPensionSyncPreference { get; set; }
        public DateTime? SubmitToPensionSyncDateTime { get; set; }
        public bool SaveChangesToDefaultSettings { get; set; }
        public bool FromPayRunAutomation { get; set; }
    }
}
