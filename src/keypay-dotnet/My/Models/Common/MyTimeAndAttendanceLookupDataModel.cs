using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class MyTimeAndAttendanceLookupDataModel
    {
        public IList<LocationSelectModel> Locations { get; set; }
        public IList<WorkTypeSelectModel> WorkTypes { get; set; }
        public LocationSelectModel DefaultLocation { get; set; }
        public IList<ShiftConditionSelectModel> ShiftConditions { get; set; }
        public IList<LocationShiftConditionsModel> LocationShiftConditions { get; set; }
        public bool ReportingDimensionsEnabled { get; set; }
        public IList<NumericNullableSelectListItem> ReportingDimensionGroups { get; set; }
        public IList<ReportingDimensionValueSelectModel> ReportingDimensionValues { get; set; }
    }
}
