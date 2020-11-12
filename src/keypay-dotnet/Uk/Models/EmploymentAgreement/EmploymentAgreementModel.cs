using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmploymentAgreement
{
    public class EmploymentAgreementModel
    {
        public int Id { get; set; }
        public string Classification { get; set; }
        public EmploymentTypeEnum EmploymentType { get; set; }
        public PayRateTemplateTypeEnum PayRateTemplateType { get; set; }
        public int? PayConditionRuleSetId { get; set; }
        public PayConditionRuleSetModel PayConditionRuleSet { get; set; }
        public IList<LeaveAllowanceTemplateModel> LeaveAllowanceTemplates { get; set; }
        public IList<Int32> LeaveAllowanceTemplateIds { get; set; }
        public IList<EmploymentAgreementPayRateTemplateModel> AgePayRateTemplates { get; set; }
        public string ExternalId { get; set; }
        public ExternalService Source { get; set; }
        public int Rank { get; set; }
    }
}
