using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class ReportLeaveLiabilityPreparationResponse
    {
        public Guid JobId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LongRunningJobStatus Status { get; set; }
    }
}
