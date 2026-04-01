using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Award
{
    public class AwardInstallRequest
    {
        public int? AwardPackageVersionId { get; set; }
        public bool? UpdateRuleSets { get; set; }
        public bool? UpdatePayRates { get; set; }
        public bool? ReApplyLeaveAllowanceTemplates { get; set; }
        public bool? PreserveCustomRules { get; set; }
        public bool? PreserveDisabledRules { get; set; }
        public bool? PreserveCustomPayCategories { get; set; }
        public bool? PreserveCustomRuleSetPeriod { get; set; }
        public bool? PreserveCustomWorkTypes { get; set; }
        public bool? PreserveCustomLeaveAllowanceTemplates { get; set; }
        public bool? PreserveAutoProgressionSettings { get; set; }
        public bool? PreserveCustomPayRateTemplates { get; set; }
        public bool? PreserveCustomEmploymentAgreements { get; set; }
    }
}
