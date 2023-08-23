using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
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
