using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PaySchedule
{
    public class PayScheduleDateForecastResultApiModel
    {
        public int PayScheduleId { get; set; }
        public DateTime NextScheduledFromDate { get; set; }
        public DateTime NextScheduledToDate { get; set; }
        public DateTime NextScheduledPaidDate { get; set; }
    }
}
