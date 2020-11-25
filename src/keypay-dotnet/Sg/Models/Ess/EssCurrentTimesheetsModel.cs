using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Ess
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
