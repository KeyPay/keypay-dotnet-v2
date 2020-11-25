using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class NzPayRunEarningsLineResponseModel
    {
        public Dictionary<string,List<NzEarningsLineModel>> EarningsLines { get; set; }
        public int PayRunId { get; set; }
    }
}
