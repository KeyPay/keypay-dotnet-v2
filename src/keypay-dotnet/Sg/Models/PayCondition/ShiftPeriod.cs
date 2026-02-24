using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayCondition
{
    public class ShiftPeriod
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
