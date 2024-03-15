using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class PayRunSuperBatchModel
    {
        public int SuperInterchangeId { get; set; }
        public string Description { get; set; }
    }
}
