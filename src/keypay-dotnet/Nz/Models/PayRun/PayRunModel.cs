using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class PayRunModel
    {
        public int Id { get; set; }
        public DateTime? DateFinalised { get; set; }
        public int PayScheduleId { get; set; }
        public DateTime PayPeriodStarting { get; set; }
        public DateTime PayPeriodEnding { get; set; }
        public DateTime DatePaid { get; set; }
        public bool IsFinalised { get; set; }
        public bool PaySlipsPublished { get; set; }
        public string Notation { get; set; }
        public string ExternalId { get; set; }
    }
}
