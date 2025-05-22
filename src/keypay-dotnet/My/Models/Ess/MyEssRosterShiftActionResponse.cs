using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class MyEssRosterShiftActionResponse
    {
        public MyEssRosterShiftModel Shift { get; set; }
        public int PendingShiftCount { get; set; }
        public int ProposedSwapCount { get; set; }
        public int NotAcceptedShiftsCount { get; set; }
    }
}
