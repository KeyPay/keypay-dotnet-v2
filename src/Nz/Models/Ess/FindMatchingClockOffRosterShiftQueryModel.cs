using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class FindMatchingClockOffRosterShiftQueryModel
    {
        public DateTime LocalTime { get; set; }
    }
}
