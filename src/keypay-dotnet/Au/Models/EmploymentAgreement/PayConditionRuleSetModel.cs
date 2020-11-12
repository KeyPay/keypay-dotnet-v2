using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class PayConditionRuleSetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RuleSetPeriodType PeriodType { get; set; }
        public int? DayOfWeekEnding { get; set; }
        public int? DayOfMonthEnding { get; set; }
        public DateTime? PeriodEnding { get; set; }
        public ShiftConsolidationOption? ShiftConsolidationOption { get; set; }
        public TimeSpan? ShiftConsolidationThreshold { get; set; }
        public string RulesJson { get; set; }
        public IList<String> DisabledRules { get; set; }
    }
}
