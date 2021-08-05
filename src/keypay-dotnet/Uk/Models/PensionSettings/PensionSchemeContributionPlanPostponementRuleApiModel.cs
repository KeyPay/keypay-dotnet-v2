using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PensionSettings
{
    public class PensionSchemeContributionPlanPostponementRuleApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PostponementRuleTypeEnum PostponementRuleType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PostponementRuleOptionTypeEnum PostponementRuleOptionType { get; set; }
        public int PostponementPeriod { get; set; }
        public int PensionSchemeContributionPlanId { get; set; }
        public string Name { get; set; }
    }
}
