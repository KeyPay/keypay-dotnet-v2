using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class AuPayRunEarningsLineResponseModel
    {
        public Dictionary<string,List<AuEarningsLineModel>> EarningsLines { get; set; }
        public int PayRunId { get; set; }
    }
}
