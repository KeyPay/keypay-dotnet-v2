using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.RosterShift
{
    public class FindMatchingClockOnRosterShiftQueryModel
    {
        public int KioskId { get; set; }
        public DateTime DateUtc { get; set; }
    }
}
