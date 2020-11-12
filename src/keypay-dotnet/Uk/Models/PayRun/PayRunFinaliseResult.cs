using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class PayRunFinaliseResult
    {
        public JournalExportResult JournalExportResult { get; set; }
        public string JournalExportFailedMessage { get; set; }
        public IList<Int32> RemovedEmployees { get; set; }
        public PaySlipNotificationResponse Notifications { get; set; }
        public bool PaySlipsPublished { get; set; }
        public PublishPaySlipsPreference PublishPreference { get; set; }
        public DateTime? DatePaid { get; set; }
        public bool ExportJournalsPreference { get; set; }
        public DateTime? PublishPaySlipsScheduledDateTimeUtc { get; set; }
        public TimeSpan? PublishPreferenceTimeOfDay { get; set; }
        public Guid? PayRunLodgementJobId { get; set; }
        public Guid? PensionSyncJobId { get; set; }
        public int ActiveEmployees { get; set; }
    }
}
