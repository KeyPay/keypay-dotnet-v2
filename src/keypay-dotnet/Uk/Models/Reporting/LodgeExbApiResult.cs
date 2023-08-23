using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class LodgeExbApiResult
    {
        public List<ExbSubmissionErrorModel> Errors { get; set; }
        public bool HasErrors { get; set; }
        public string SubmissionSecureRequest { get; set; }
        public string TransactionId { get; set; }
        public Guid ScheduledJobId { get; set; }
        public decimal DelayInMilliseconds { get; set; }
    }
}
