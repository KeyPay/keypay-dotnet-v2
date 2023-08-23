using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmploymentAgreement
{
    public class RuleEvaluationResult
    {
        public string RuleName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RuleMatchResult MatchResult { get; set; }
    }
}
