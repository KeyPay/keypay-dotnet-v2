using System.Collections.Generic;
using KeyPay.DomainModels.V2.Location;
using KeyPay.DomainModels.V2.WorkType;

namespace KeyPay.DomainModels.V2.TimeAndAttendance
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