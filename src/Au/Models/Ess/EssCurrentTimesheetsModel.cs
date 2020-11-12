using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EssCurrentTimesheetsModel
    {
        public DateTime PeriodStarting { get; set; }
        public DateTime PeriodEnding { get; set; }
        public int SubmittedCount { get; set; }
        public int ApprovedCount { get; set; }
        public int RejectedCount { get; set; }
        public int ProcessedCount { get; set; }
        public decimal DurationInMinutes { get; set; }
    }
}
