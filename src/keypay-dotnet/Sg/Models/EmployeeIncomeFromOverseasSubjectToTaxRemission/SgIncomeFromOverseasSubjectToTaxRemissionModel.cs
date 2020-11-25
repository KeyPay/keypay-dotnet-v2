using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.EmployeeIncomeFromOverseasSubjectToTaxRemission
{
    public class SgIncomeFromOverseasSubjectToTaxRemissionModel
    {
        public int Id { get; set; }
        public int BasisPeriod { get; set; }
        public SgIncomeType IncomeType { get; set; }
        public decimal? IncomeAmount { get; set; }
        public PeriodOfOverseasPostingType PeriodOfOverseasPostingType { get; set; }
        public decimal? ExemptIncomeAmount { get; set; }
        public bool? ContributionsToOverseasFunds { get; set; }
        public string OverseasFundName { get; set; }
        public decimal? ContributionsWithTaxConcession { get; set; }
        public decimal? ContributionsWithoutTaxConcession { get; set; }
        public bool? ContributionsMandatory { get; set; }
        public bool? ContributionsChargedDeductionsClaimedSingaporeEstablishment { get; set; }
    }
}
