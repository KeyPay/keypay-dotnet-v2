using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class PayScheduleDateForecastResultApiModel
    {
        public int PayScheduleId { get; set; }
        public DateTime NextScheduledFromDate { get; set; }
        public DateTime NextScheduledToDate { get; set; }
        public DateTime NextScheduledPaidDate { get; set; }
    }
}
