using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveCategories
{
    public class LeaveCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LeaveAllowanceUnitEnum UnitType { get; set; }
        public decimal Units { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool IsPrivate { get; set; }
        public bool ExcludeFromTerminationPayout { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public decimal LeaveLoading { get; set; }
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        public bool IsBalanceUntracked { get; set; }
        public LeaveCategoryTypeEnum LeaveCategoryType { get; set; }
        public bool DeductFromPrimaryPayCategory { get; set; }
        public int? DeductFromPayCategoryId { get; set; }
        public int? TransferToPayCategoryId { get; set; }
        public bool HideAccrualsOnPayslip { get; set; }
        public bool UseDeductFromPayCategoryRate { get; set; }
        public LeaveAccrualRuleModel LeaveAccrualRule { get; set; }
        public bool IsNamePrivate { get; set; }
        public bool UseGrossPaymentRate { get; set; }
        public LeaveUnitTypeEnum LeaveUnitType { get; set; }
    }
}
