using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveCategories
{
    public class NzBusinessHolidayLeaveSettingsApiModel
    {
        public int? AnnualHolidayLeaveCategoryId { get; set; }
        public int? AlternativeHolidayLeaveCategoryId { get; set; }
        public int? LeaveWithoutPayLeaveCategoryId { get; set; }
        public bool Use12MonthsForMonthlyEmployeesDailyRateCalc { get; set; }
        public int? DefaultIrregularWorkPatternPeriod { get; set; }
    }
}
