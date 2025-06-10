using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.ReportingDimensions
{
    public class ReportingDimensionValueApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public string ExternalId { get; set; }
        public bool AllEmployees { get; set; }
        public string SpecificEmployees { get; set; }
        public string FilterCombinationStrategy { get; set; }
        public IList<ReportingDimensionValueFilterApiModel> Filters { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReportingDimensionId { get; set; }
    }
}
