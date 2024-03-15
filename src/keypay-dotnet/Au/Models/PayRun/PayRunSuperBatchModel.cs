using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class PayRunSuperBatchModel
    {
        public int SuperInterchangeId { get; set; }
        public string Description { get; set; }
    }
}
