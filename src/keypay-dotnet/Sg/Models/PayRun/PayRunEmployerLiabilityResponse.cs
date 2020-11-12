using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class PayRunEmployerLiabilityResponse
    {
        public Dictionary<string,List<EmployerLiabilityModel>> EmployerLiabilities { get; set; }
        public int PayRunId { get; set; }
    }
}
