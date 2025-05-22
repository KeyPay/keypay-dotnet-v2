using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PaySchedule
{
    public class PayScheduleDateForecastResultApiModel
    {
        public int PayScheduleId { get; set; }
        public DateTime NextScheduledFromDate { get; set; }
        public DateTime NextScheduledToDate { get; set; }
        public DateTime NextScheduledPaidDate { get; set; }
    }
}
