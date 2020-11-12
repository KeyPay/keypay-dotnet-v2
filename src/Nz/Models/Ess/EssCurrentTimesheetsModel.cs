using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
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
