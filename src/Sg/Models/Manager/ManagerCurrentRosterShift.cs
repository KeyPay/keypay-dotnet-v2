using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class ManagerCurrentRosterShift
    {
        public TimeAttendanceStatus Status { get; set; }
        public bool IsLate { get; set; }
        public bool IsNotClockedOff { get; set; }
    }
}
