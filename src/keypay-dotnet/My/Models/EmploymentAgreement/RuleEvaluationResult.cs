using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmploymentAgreement
{
    public class RuleEvaluationResult
    {
        public string RuleName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RuleMatchResult MatchResult { get; set; }
    }
}
