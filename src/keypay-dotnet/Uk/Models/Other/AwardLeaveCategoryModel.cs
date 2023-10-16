using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class AwardLeaveCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAllowanceUnitEnum UnitType { get; set; }
        public decimal Units { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool IsPrivate { get; set; }
        public bool ExcludeFromTerminationPayout { get; set; }
        public bool PayoutNegativeBalance { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public decimal LeaveLoading { get; set; }
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        public bool IsBalanceUntracked { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveCategoryTypeEnum LeaveCategoryType { get; set; }
        public bool DeductFromPrimaryPayCategory { get; set; }
        public int? DeductFromPayCategoryId { get; set; }
        public string DeductFromSystemPayCategoryName { get; set; }
        public int? TransferToPayCategoryId { get; set; }
        public string TransferToSystemPayCategoryName { get; set; }
        public int? TransferUnusedLeaveToPayCategoryId { get; set; }
        public string TransferUnusedLeaveToSystemPayCategoryName { get; set; }
        public bool HideAccrualsOnPayslip { get; set; }
        public bool UseDeductFromPayCategoryRate { get; set; }
        public LeaveAccrualRuleViewModel LeaveAccrualRule { get; set; }
        public bool IsNamePrivate { get; set; }
        public bool? AccruesFirstPayRunPerPeriodOnly { get; set; }
        public int? PreventNegativeBalanceUnpaidLeaveCategoryId { get; set; }
    }
}
