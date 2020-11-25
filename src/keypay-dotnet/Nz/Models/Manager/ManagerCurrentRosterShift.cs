using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Manager
{
    public class ManagerCurrentRosterShift
    {
        public TimeAttendanceStatus Status { get; set; }
        public bool IsLate { get; set; }
        public bool IsNotClockedOff { get; set; }
    }
}
