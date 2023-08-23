using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class UkAcceptRosterShiftsResponseModel
    {
        public IList<UkEssRosterShiftModel> Shifts { get; set; }
        public int ProposedSwapCount { get; set; }
        public int PendingShiftCount { get; set; }
        public int BiddableShiftCount { get; set; }
        public int NotAcceptedShiftsCount { get; set; }
    }
}
