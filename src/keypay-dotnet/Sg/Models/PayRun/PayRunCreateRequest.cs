using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class PayRunCreateRequest
    {
        public int PayScheduleId { get; set; }
        public DateTime PayPeriodEnding { get; set; }
        public DateTime DatePaid { get; set; }
        public TimesheetImportOption? TimesheetImportOption { get; set; }
        public string ExternalId { get; set; }
        public string CallbackUrl { get; set; }
        public bool? CreateWithEmptyPays { get; set; }
        public bool? Adhoc { get; set; }
    }
}
