using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSmpPaymentApiModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WeekNumber { get; set; }
        public bool Include { get; set; }
        public bool OffsetSmp { get; set; }
        public decimal? Amount { get; set; }
        public int? PayRunId { get; set; }
        public DoNotPaySmpReasonEnum? DoNotPayReason { get; set; }
        public string Status { get; set; }
        public int DaysPaid { get; set; }
        public bool? PaySalaryOnTop { get; set; }
    }
}
