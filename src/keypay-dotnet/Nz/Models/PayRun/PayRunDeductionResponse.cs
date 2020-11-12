using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class PayRunDeductionResponse
    {
        public Dictionary<string,List<DeductionModel>> DeductionList { get; set; }
        public int PayRunId { get; set; }
    }
}
