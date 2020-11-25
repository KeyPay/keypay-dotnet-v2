using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class PaySlipNotificationResponse
    {
        public int TotalEmailNotificationsSent { get; set; }
        public int TotalSmsNotificationsSent { get; set; }
        public PayRunWarningResult Errors { get; set; }
        public bool HasPartiallySentNotifications { get; set; }
    }
}
