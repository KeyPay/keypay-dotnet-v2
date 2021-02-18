using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
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
    }
}
