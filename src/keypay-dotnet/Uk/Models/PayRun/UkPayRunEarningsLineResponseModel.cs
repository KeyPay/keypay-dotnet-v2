using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkPayRunEarningsLineResponseModel
    {
        public Dictionary<string,List<UkEarningsLineModel>> EarningsLines { get; set; }
        public int PayRunId { get; set; }
    }
}
