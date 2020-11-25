using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class PaySlipNotificationResponse
    {
        public int TotalEmailNotificationsSent { get; set; }
        public int TotalSmsNotificationsSent { get; set; }
        public PayRunWarningResult Errors { get; set; }
        public bool HasPartiallySentNotifications { get; set; }
    }
}
