using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class UkEmployeeBenefitCategoryExtVanFuelEditModel
    {
        public decimal AmountForegone { get; set; }
        public decimal? OpraAmountForegone { get; set; }
        public DateTime? AvailableToDate { get; set; }
        public decimal CashEquivalent { get; set; }
        public int StartFromPeriod { get; set; }
        public decimal AmountPayrolledToDate { get; set; }
        public decimal AmountToBePayrolledPerPeriod { get; set; }
        public bool ProRataInFirstPayRun { get; set; }
    }
}
