using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class AuEssRosterShiftActionResponse
    {
        public AuEssRosterShiftModel Shift { get; set; }
        public int PendingShiftCount { get; set; }
        public int ProposedSwapCount { get; set; }
    }
}
