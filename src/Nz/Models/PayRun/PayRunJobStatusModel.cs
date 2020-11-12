using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class PayRunJobStatusModel
    {
        public int PayRunId { get; set; }
        public string Status { get; set; }
        public string ExternalId { get; set; }
    }
}
