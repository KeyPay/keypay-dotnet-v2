using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class UkEmployeeBenefitCategoryModel
    {
        public int? BenefitCategoryId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool CarryBenefitForward { get; set; }
        public decimal AmountForegone { get; set; }
        public decimal AmountMadeGood { get; set; }
        public decimal CashEquivalent { get; set; }
        public int StartFromPeriod { get; set; }
        public decimal AmountPayrolledToDate { get; set; }
        public decimal AmountToBePayrolledPerPeriod { get; set; }
        public decimal? AmountPayrolledToDateInPayRuns { get; set; }
        public decimal? AdditionalAmountPayrolledToDateInPayRuns { get; set; }
        public bool HasLinkedPayRuns { get; set; }
        public int Id { get; set; }
        public string BenefitCategoryName { get; set; }
        public string BenefitCategoryType { get; set; }
        public int Year { get; set; }
        public IList<String> CalculationLogs { get; set; }
        public UkEmployeeBenefitProRataCalculationModel ProRataCalculation { get; set; }
        public UkEmployeeBenefitCategoryExtCarEditModel Car { get; set; }
    }
}
