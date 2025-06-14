using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class AuPayRunDetailsModel
    {
        public IList<AuPayRunTotalDetailModel> PayRunTotals { get; set; }
        public AuPayRunGrandTotalModel GrandTotal { get; set; }
        public PayRunModel PayRun { get; set; }
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
