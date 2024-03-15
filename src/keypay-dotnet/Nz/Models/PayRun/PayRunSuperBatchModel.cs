using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class PayRunSuperBatchModel
    {
        public int SuperInterchangeId { get; set; }
        public string Description { get; set; }
    }
}
