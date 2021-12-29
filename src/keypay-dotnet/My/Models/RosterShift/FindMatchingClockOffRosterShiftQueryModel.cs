using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.RosterShift
{
    public class FindMatchingClockOffRosterShiftQueryModel
    {
        public int KioskId { get; set; }
        public DateTime DateUtc { get; set; }
    }
}
