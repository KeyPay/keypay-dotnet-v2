using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class PayRunJobStatusModel
    {
        public int PayRunId { get; set; }
        public string Status { get; set; }
        public string ExternalId { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
