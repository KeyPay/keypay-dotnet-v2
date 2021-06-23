using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class ExbXmlApiModel
    {
        public int TaxYearEnding { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExbSubmissionType ExbSubmissionType { get; set; }
    }
}
