using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
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
        [JsonConverter(typeof(StringEnumConverter))]
        public PensionTypeEnum PensionType { get; set; }
        public decimal EmployeeContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal SalarySacrifice { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PensionReportingFrequencyEnum ReportingFrequency { get; set; }
        public int PensionSchemeId { get; set; }
        public decimal MaxEarningsThreshold { get; set; }
        public decimal MinEarningsThreshold { get; set; }
        public int? SalarySacrificeDeductionCategoryId { get; set; }
        public decimal NicSavingRebate { get; set; }
        public bool? IsAutoEnrolmentScheme { get; set; }
        public decimal? LowerEarningsDisregard { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DefaultLELOffsetEnum? LowerDefaultEarningsDisregardType { get; set; }
        public decimal? UpperEarningsCap { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DefaultUETOffsetEnum? UpperDefaultEarningsCapType { get; set; }
        public List<PensionSchemeContributionPlanPostponementRuleApiModel> PensionSchemeContributionPlanPostponementRules { get; set; }
        public string CollectionSourceId { get; set; }
    }
}
