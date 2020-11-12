using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PensionSettings
{
    public class PensionSchemeContributionPlanApiModel
    {
        public int? Id { get; set; }
        public string ContributionGroupName { get; set; }
        public string ContributionGroupId { get; set; }
        public string ContributionPlanName { get; set; }
        public bool CalculateOnQualifyingEarnings { get; set; }
        public PensionTypeEnum PensionType { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal SalarySacrifice { get; set; }
        public PensionReportingFrequencyEnum ReportingFrequency { get; set; }
        public int PensionSchemeId { get; set; }
        public decimal MaxEarningsThreshold { get; set; }
        public decimal MinEarningsThreshold { get; set; }
        public int? SalarySacrificeDeductionCategoryId { get; set; }
        public decimal NicSavingRebate { get; set; }
        public bool? IsAutoEnrolmentScheme { get; set; }
        public decimal? LowerEarningsDisregard { get; set; }
        public DefaultLELOffsetEnum? LowerDefaultEarningsDisregardType { get; set; }
        public decimal? UpperEarningsCap { get; set; }
        public DefaultUETOffsetEnum? UpperDefaultEarningsCapType { get; set; }
        public List<Int32> SalarySacrificePayCategoryIds { get; set; }
        public List<Int32> EmployeeContributionPayCategoryIds { get; set; }
        public List<Int32> EmployerContributionPayCategoryIds { get; set; }
    }
}
