using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSpbpDataApiModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ChildDeathDate { get; set; }
        public decimal WeeksPaid { get; set; }
        public decimal? WeeksToPay { get; set; }
        public DateTime? PrevSpbpStartDate { get; set; }
        public DateTime? PrevSpbpEndDate { get; set; }
        public decimal? AverageWeeklyEarningsOverride { get; set; }
        public decimal? EmployerPensionProtection { get; set; }
        public bool OffsetSpbp { get; set; }
        public bool PayLumpSum { get; set; }
        public IList<UkSpbpApiModel> Spbp { get; set; }
        public DoNotPaySpbpReasonEnum? DoNotPayReason { get; set; }
        public decimal? SpbpAdjust { get; set; }
        public string Notes { get; set; }
    }
}
