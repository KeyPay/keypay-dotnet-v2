using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class ShiftPartModel
    {
        public bool IsBreak { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan EffectiveDuration { get; set; }
        public TimeSpan ActualDuration { get; set; }
        public string PayCategory { get; set; }
        public int PayCategoryId { get; set; }
        public decimal Cost { get; set; }
        public decimal? RateMultiplier { get; set; }
        public decimal BaseRate { get; set; }
        public decimal CalculatedRate { get; set; }
        public string DisplayDuration { get; set; }
        public NominalWorkType WorkType { get; set; }
        public NominalClassification Classification { get; set; }
        public NominalLeaveCategory LeaveCategory { get; set; }
    }
}
