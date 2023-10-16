using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class AwardPackageDataModel
    {
        public IList<EmploymentAgreementModel> EmploymentAgreements { get; set; }
        public IList<ConsolidatedPayCategoryModel> PayCategories { get; set; }
        public IList<AwardLeaveCategoryModel> LeaveCategories { get; set; }
        public IList<EmployeeExpenseCategoryModel> ExpenseCategories { get; set; }
        public IList<WorkTypeModel> WorkTypes { get; set; }
        public IList<TagModel> Tags { get; set; }
        public IList<QualificationModel> Qualifications { get; set; }
        public IList<PayConditionRuleSetModel> RuleSets { get; set; }
        public IList<PayRateTemplateModel> PayRateTemplates { get; set; }
        public IList<LeaveAllowanceTemplateModel> LeaveAllowanceTemplates { get; set; }
    }
}
