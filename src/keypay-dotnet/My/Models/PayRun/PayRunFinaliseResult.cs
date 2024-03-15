using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class PayRunFinaliseResult
    {
        public JournalExportResult JournalExportResult { get; set; }
        public string JournalExportFailedMessage { get; set; }
        public IList<Int32> RemovedEmployees { get; set; }
        public PaySlipNotificationResponse Notifications { get; set; }
        public bool PaySlipsPublished { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PublishPaySlipsPreference PublishPreference { get; set; }
        public DateTime? DatePaid { get; set; }
        public bool ExportJournalsPreference { get; set; }
        public DateTime? PublishPaySlipsScheduledDateTimeUtc { get; set; }
        public Guid? PayRunLodgementJobId { get; set; }
        public Guid? PensionSyncJobId { get; set; }
        public int ActiveEmployees { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference PublishPaySlips { get; set; }
        public TimeSpan? PublishPreferenceTimeOfDay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference ExportJournals { get; set; }
        public DateTime? ExportJournalsScheduledDateTimeUtc { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference LodgePayRun { get; set; }
        public DateTime? LodgePayRunScheduledDateTimeUtc { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference RunReportPacks { get; set; }
        public DateTime? RunReportPacksScheduledDateTimeUtc { get; set; }
        public bool AreReportPacksProcessed { get; set; }
        public List<String> SelectedReportPacks { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRunFinaliseActionPreference SubmitToPensionSync { get; set; }
        public DateTime? SubmitToPensionSyncScheduledDateTimeUtc { get; set; }
        public IList<PayRunSuperBatchModel> SuperPayments { get; set; }
        public bool IsFirstFinalisation { get; set; }
    }
}
