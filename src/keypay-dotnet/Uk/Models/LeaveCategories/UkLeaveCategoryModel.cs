using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveCategories
{
    public class UkLeaveCategoryModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public UkLeaveAllowanceUnitType UnitType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveCategoryTypeEnum LeaveCategoryType { get; set; }
        public bool PayoutNegativeBalance { get; set; }
        public LeaveAccrualRuleModel LeaveAccrualRule { get; set; }
        public bool IncludeIn52WeekAverageCalculation { get; set; }
        public bool Apply30MinuteRoundingRules { get; set; }
        public bool IsOpenEnded { get; set; }
        public int? DaysWorkedBeforeRecalculating { get; set; }
        public int? UnpaidDaysAtStartOfSickPeriod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveCategoryUkOccupationalAbsenceServiceBandType OccupationalAbsenceServiceBandType { get; set; }
        public IList<UkLeaveCategoryUkOccupationalAbsenceServiceBandModel> OccupationalAbsenceServiceBands { get; set; }
        public IList<UkLeaveCategoryUkOccupationalAbsencePaymentBandModel> OccupationalAbsencePaymentBands { get; set; }
        public string OccupationalAbsenceServiceBandTypeDescription { get; set; }
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
