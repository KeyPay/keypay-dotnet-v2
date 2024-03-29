using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class JournalExportResult
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public JournalExportStatus Status { get; set; }
        public string Message { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService JournalSource { get; set; }
        public string JournalExternalReferenceId { get; set; }
    }
}
