using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.ReportingDimensions
{
    public class ReportingDimensionValueApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReportingDimensionId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public string ExternalId { get; set; }
    }
}
