using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class PaySlipNotificationResponse
    {
        public int TotalEmailNotificationsSent { get; set; }
        public int TotalSmsNotificationsSent { get; set; }
        public PayRunWarningResult Errors { get; set; }
        public bool HasPartiallySentNotifications { get; set; }
    }
}
