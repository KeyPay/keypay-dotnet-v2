using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Common
{
    public class StatutoryLeaveLogEvent
    {
        public StatutoryLeaveLogEventTypeEnum Type { get; set; }
        public StatutoryLeaveLogCategoryEnum Category { get; set; }
        public string Message { get; set; }
    }
}
