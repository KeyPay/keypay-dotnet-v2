using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSmpApiResponseModel
    {
        public int LeaveAccrualId { get; set; }
        public SmpEligibilityEnum Status { get; set; }
        public IList<StatutoryLeaveLogEvent> Log { get; set; }
        public IList<UkSmpApiRateResponseModel> Rates { get; set; }
    }
}
