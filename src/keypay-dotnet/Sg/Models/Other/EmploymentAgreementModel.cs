using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class EmploymentAgreementModel
    {
        public int Id { get; set; }
        public string Classification { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmploymentTypeEnum EmploymentType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayRateTemplateTypeEnum PayRateTemplateType { get; set; }
        public int? PayConditionRuleSetId { get; set; }
        public PayConditionRuleSetModel PayConditionRuleSet { get; set; }
        public IList<LeaveAllowanceTemplateModel> LeaveAllowanceTemplates { get; set; }
        public IList<Int32> LeaveAllowanceTemplateIds { get; set; }
        public IList<EmploymentAgreementPayRateTemplateModel> AgePayRateTemplates { get; set; }
        public string ExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public int Rank { get; set; }
    }
}
