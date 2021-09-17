using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PaySchedule
{
    public class PayScheduleDateForecastResultApiModel
    {
        public DateTime NextScheduledPayRunDate { get; set; }
        public DateTime NextScheduledFromDate { get; set; }
        public DateTime NextScheduledToDate { get; set; }
        public DateTime NextScheduledPaidDate { get; set; }
    }
}
