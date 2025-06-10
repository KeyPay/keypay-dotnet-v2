using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class PayScheduleApprovalSettingsModel
    {
        public bool RequireApproval { get; set; }
        public int ReminderDay { get; set; }
        public string NotificationTemplate { get; set; }
        public string NotificationSubject { get; set; }
        public string ReminderTemplate { get; set; }
        public string ReminderSubject { get; set; }
        public bool SendReminder { get; set; }
        public List<String> ApproversToNotify { get; set; }
    }
}
