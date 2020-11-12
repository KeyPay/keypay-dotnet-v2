using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class TimeAndAttendanceLookupDataModel
    {
        public IList<LocationSelectModel> Locations { get; set; }
        public IList<WorkTypeSelectModel> WorkTypes { get; set; }
        public IList<ClassificationLookupModel> Classifications { get; set; }
        public LocationSelectModel DefaultLocation { get; set; }
        public IList<ShiftConditionSelectModel> ShiftConditions { get; set; }
        public IList<LocationShiftConditionsModel> LocationShiftConditions { get; set; }
    }
}
