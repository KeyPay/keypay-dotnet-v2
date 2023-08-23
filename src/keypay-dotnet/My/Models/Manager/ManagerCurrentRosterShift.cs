using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class ManagerCurrentRosterShift
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeAttendanceStatus Status { get; set; }
        public bool IsLate { get; set; }
        public bool IsNotClockedOff { get; set; }
    }
}
