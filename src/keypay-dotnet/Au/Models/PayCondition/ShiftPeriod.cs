using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayCondition
{
    public class ShiftPeriod
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
