using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class FindNearbyRosterShiftsQueryModel
    {
        public DateTime LocalTime { get; set; }
    }
}
