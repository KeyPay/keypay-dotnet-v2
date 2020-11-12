using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmploymentAgreement
{
    public class RuleEvaluationResult
    {
        public string RuleName { get; set; }
        public RuleMatchResult MatchResult { get; set; }
    }
}
