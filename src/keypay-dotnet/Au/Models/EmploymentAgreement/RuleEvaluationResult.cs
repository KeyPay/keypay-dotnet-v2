using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class RuleEvaluationResult
    {
        public string RuleName { get; set; }
        public RuleMatchResult MatchResult { get; set; }
    }
}
