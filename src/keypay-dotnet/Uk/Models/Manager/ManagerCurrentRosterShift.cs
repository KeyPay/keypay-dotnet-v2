using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Manager
{
    public class ManagerCurrentRosterShift
    {
        public TimeAttendanceStatus Status { get; set; }
        public bool IsLate { get; set; }
        public bool IsNotClockedOff { get; set; }
    }
}
