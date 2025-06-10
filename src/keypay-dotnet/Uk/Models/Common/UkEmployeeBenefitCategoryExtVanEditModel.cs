using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class UkEmployeeBenefitCategoryExtVanEditModel
    {
        public decimal? OpraAmountForegone { get; set; }
        public DateTime AvailableFromDate { get; set; }
        public DateTime? AvailableToDate { get; set; }
        public int? NumberOfDaysUnavailable { get; set; }
        public decimal AmountPaidByEmployeeForPrivateUse { get; set; }
        public bool IsShared { get; set; }
        public decimal? SharedPercentage { get; set; }
        public bool EmployerProvidesFuelForPrivateUse { get; set; }
        public UkEmployeeBenefitCategoryExtVanFuelEditModel Fuel { get; set; }
    }
}
