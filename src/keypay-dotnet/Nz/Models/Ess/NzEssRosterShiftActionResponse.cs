using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class NzEssRosterShiftActionResponse
    {
        public NzEssRosterShiftModel Shift { get; set; }
        public int PendingShiftCount { get; set; }
        public int ProposedSwapCount { get; set; }
        public int NotAcceptedShiftsCount { get; set; }
    }
}
