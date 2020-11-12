using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class EmployeePensionContributionPlanSettingsApiModel
    {
        public PensionAssessmentStatusEnum? AssessmentStatus { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public bool? OptIn { get; set; }
        public DateTime? OptInDate { get; set; }
        public int? PensionContributionPlanId { get; set; }
        public decimal? OverrideMaxEarningsThreshold { get; set; }
        public decimal? OverrideMinEarningsThreshold { get; set; }
        public decimal? OverrideEmployeeContribution { get; set; }
        public decimal? OverrideEmployerContribution { get; set; }
        public decimal? OverrideSalarySacrifice { get; set; }
        public DateTime? AutoEnrolOptOutDate { get; set; }
        public string AutoEnrolOptOutReference { get; set; }
        public bool ProcessOptOutRefunds { get; set; }
        public PensionAssessmentOptionEnum? PensionAssessmentOption { get; set; }
        public bool Enrolled { get; set; }
        public PostponementOptionEnum? PostponementOption { get; set; }
        public DateTime? DeferralDate { get; set; }
    }
}
