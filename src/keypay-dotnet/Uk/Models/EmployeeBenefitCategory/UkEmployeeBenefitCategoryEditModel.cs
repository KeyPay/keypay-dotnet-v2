using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeBenefitCategory
{
    public class UkEmployeeBenefitCategoryEditModel
    {
        public int? BenefitCategoryId { get; set; }
        public int EmployeeId { get; set; }
        public bool CarryBenefitForward { get; set; }
        public decimal AmountForegone { get; set; }
        public decimal AmountMadeGood { get; set; }
        public decimal CashEquivalent { get; set; }
        public int StartFromPeriod { get; set; }
        public decimal AmountPayrolledToDate { get; set; }
        public decimal AmountToBePayrolledPerPeriod { get; set; }
        public int Year { get; set; }
        public UkEmployeeBenefitProRataCalculationModel ProRataCalculation { get; set; }
        public UkEmployeeBenefitCategoryExtCarEditModel Car { get; set; }
    }
}
