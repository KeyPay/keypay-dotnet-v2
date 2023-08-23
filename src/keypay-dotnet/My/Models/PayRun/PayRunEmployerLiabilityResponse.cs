using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class PayRunEmployerLiabilityResponse
    {
        public Dictionary<string,List<EmployerLiabilityModel>> EmployerLiabilities { get; set; }
        public int PayRunId { get; set; }
    }
}
