using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Common
{
    public class UkSspApiModel
    {
        public int Id { get; set; }
        public int? WaitingDays { get; set; }
        public int QualifyingDays { get; set; }
        public bool QualifiesForSsp { get; set; }
        public DoNotPaySspReasonEnum? DoNotPayReason { get; set; }
        public IList<DayOfWeek> Week1QualifyingDays { get; set; }
        public IList<DayOfWeek> Week2QualifyingDays { get; set; }
        public decimal? AverageWeeklyEarningsOverride { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
    }
}
