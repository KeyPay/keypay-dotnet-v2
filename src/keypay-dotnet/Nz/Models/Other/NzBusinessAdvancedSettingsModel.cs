using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class NzBusinessAdvancedSettingsModel
    {
        public bool EnableContractorManagement { get; set; }
        public bool HasContractorSetup { get; set; }
        public int OtherwiseWorkingDayOccurrences { get; set; }
        public int OtherwiseWorkingDayPeriod { get; set; }
        public bool PublicHolidayAutomationForAutoPayEmployees { get; set; }
        public bool EnableRSEEmployment { get; set; }
        public bool ShowRSEEmploymentOption { get; set; }
        public bool AllowMultipleTopLevelLocations { get; set; }
        public bool UniqueExternalIdsForEmployee { get; set; }
        public bool UniqueExternalIdsForPayCategory { get; set; }
        public bool UniqueExternalIdsForLeaveCategory { get; set; }
        public bool UniqueExternalIdsForDeductionCategory { get; set; }
        public bool UniqueExternalIdsForEmployeeExpenseCategory { get; set; }
        public bool UniqueExternalIdsForEmployerLiabilityCategory { get; set; }
        public bool UniqueExternalIdsForLocation { get; set; }
        public bool UniqueExternalIdsForWorkType { get; set; }
        public bool EnableClockInClockOutWebhooks { get; set; }
    }
}
