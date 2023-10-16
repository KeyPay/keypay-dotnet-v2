using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveCategories
{
    public class NzLeaveCategoryModel
    {
        public bool PayoutNegativeBalance { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NzLeaveAllowanceUnitType UnitType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NzLeaveCategoryTypeEnum LeaveCategoryType { get; set; }
        public NzLeaveAccrualRuleModel LeaveAccrualRule { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Units { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool IsPrivate { get; set; }
        public bool ExcludeFromTerminationPayout { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool IsBalanceUntracked { get; set; }
        public bool DeductFromPrimaryPayCategory { get; set; }
        public int? DeductFromPayCategoryId { get; set; }
        public int? TransferToPayCategoryId { get; set; }
        public bool HideAccrualsOnPayslip { get; set; }
        public bool UseDeductFromPayCategoryRate { get; set; }
        public bool IsNamePrivate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum LeaveUnitType { get; set; }
        public bool PayoutAsETP { get; set; }
        public bool? AccruesFirstPayRunPerPeriodOnly { get; set; }
        public int? PreventNegativeBalanceUnpaidLeaveCategoryId { get; set; }
        public LeaveEntitlementModel LeaveEntitlement { get; set; }
    }
}
