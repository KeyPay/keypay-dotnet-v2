using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class PayRunDeductionResponse
    {
        public Dictionary<string,List<DeductionModel>> DeductionList { get; set; }
        public int PayRunId { get; set; }
    }
}
