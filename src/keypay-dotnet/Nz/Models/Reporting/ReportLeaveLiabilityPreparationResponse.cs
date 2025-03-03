using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class ReportLeaveLiabilityPreparationResponse
    {
        public Guid JobId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LongRunningJobStatus Status { get; set; }
    }
}
