using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmploymentAgreement
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
