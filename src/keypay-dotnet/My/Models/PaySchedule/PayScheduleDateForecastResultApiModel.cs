using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PaySchedule
{
    public class PayScheduleDateForecastResultApiModel
    {
        public int PayScheduleId { get; set; }
        public DateTime NextScheduledFromDate { get; set; }
        public DateTime NextScheduledToDate { get; set; }
        public DateTime NextScheduledPaidDate { get; set; }
    }
}
