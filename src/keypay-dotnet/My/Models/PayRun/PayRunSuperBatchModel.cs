using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class PayRunSuperBatchModel
    {
        public int SuperInterchangeId { get; set; }
        public string Description { get; set; }
    }
}
