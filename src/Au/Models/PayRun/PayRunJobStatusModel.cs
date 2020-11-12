using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class PayRunJobStatusModel
    {
        public int PayRunId { get; set; }
        public string Status { get; set; }
        public string ExternalId { get; set; }
    }
}
