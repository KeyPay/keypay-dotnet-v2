using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class FinalisePayRunOptions
    {
        public int PayRunId { get; set; }
        public DateTime? DatePaid { get; set; }
        public bool ExportJournals { get; set; }
        public PublishPaySlipsPreference PublishPaySlips { get; set; }
        public DateTime? PublishPaySlipsDateTime { get; set; }
        public bool SuppressNotifications { get; set; }
        public bool LodgePayRun { get; set; }
        public bool LodgePayRunInTestMode { get; set; }
        public bool SubmitToPensionSync { get; set; }
        public bool LodgeFinalPayRun { get; set; }
        public HmrcFpsLateSubmissionReason? RelodgeHmrcLateSubmissionReason { get; set; }
        public bool RelodgeSelectedEmployeesOnly { get; set; }
    }
}
